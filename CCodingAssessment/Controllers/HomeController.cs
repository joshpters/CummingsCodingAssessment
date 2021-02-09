using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CCodingAssessment.Data;
using CCodingAssessment.Models;
using CCodingAssessment.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CCodingAssessment.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return RedirectToAction(nameof(SubmitTransfer));
        }

        public IActionResult SubmitTransfer()
        {
            return View();
        }

        public IActionResult Success()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SubmitTransfer(TransferViewModel transfer)
        {
            if (ModelState.IsValid)
            {
                _context.ProvidingAgencies.Add(transfer.ProvidingAgency);
                _context.RequestingAgencies.Add(transfer.RequestingAgency);
                _context.Bonds.Add(transfer.Bond);
                _context.Indemnitors.Add(transfer.Indemnitor);
                _context.Defendants.Add(transfer.Defendant);
                _context.Jails.Add(transfer.Jail);

                //Save changes for EF tracking
                await _context.SaveChangesAsync();

                _context.Transfers.Add(new Transfer
                {
                    AdditionalInformation = transfer.AdditionalInformation,
                    BondId = transfer.Bond.Id,
                    DefendantId = transfer.Defendant.Id,
                    IndemnitorId = transfer.Indemnitor.Id,
                    RequestingAgencyId = transfer.RequestingAgency.Id,
                    ProvidingAgencyId = transfer.ProvidingAgency.Id,
                    JailId = transfer.Jail.Id
                });

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Success));
            }
            else
            {
                return View();
            }
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
