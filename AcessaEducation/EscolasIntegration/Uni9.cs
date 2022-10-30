using PuppeteerSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace AcessaEducation.EscolasIntegration
{
    public class Uni9
    {
        private string _loginURI = "https://aluno.uninove.br/seu/CENTRAL/aluno/";
        private Page _currentPage;
        private Browser _browser;
        public async Task AcessaUni9()
        {
            Console.WriteLine("=============================== Digite seu Ra =====================================");
            string ra = Console.ReadLine();
            Console.WriteLine("============================== Digite Sua Senha ====================================");
            string senha = Console.ReadLine();

            #region Login
            _browser = await Puppeteer.LaunchAsync(new LaunchOptions
            {
                Headless = false
            });

            await _currentPage.GoToAsync(_loginURI);
            #endregion
        }
    }
}
