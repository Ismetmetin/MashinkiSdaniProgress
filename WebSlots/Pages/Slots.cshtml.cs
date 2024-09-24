using mashinki;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SlotMachineApp.Pages
{
    public class SlotsModel : PageModel
    {
        public int Rows { get; set; }

        public int Cols { get; set; }
        public double Balance { get; set; }

        public Coin[,] Matrix { get; set; }
        public void OnGet()
        {
            Mashinka ms = new Mashinka();

            ms.Roll();
            Balance = ms.Balance;
            Matrix = ms.matrix;
            Rows = Mashinka.rows;
            Cols = Mashinka.cols;
        
        }
    }
}
