using PuppeteerSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AcessaEducation.EscolasIntegration
{
    public class Uni9
    {
        private string _loginURI = "https://aluno.uninove.br/seu/CENTRAL/aluno/";
        private Page _currentPage;
        private Browser _browser;
        private string _ra;
        private string _senha;
        public async Task AcessaUni9()
        {
            Console.WriteLine("=============================== Digite seu Ra =====================================");
            _ra = Console.ReadLine();
            Console.WriteLine("============================== Digite Sua Senha ====================================");
            _senha = Console.ReadLine();

            #region Login
            await new BrowserFetcher().DownloadAsync(BrowserFetcher.DefaultRevision);
            _browser = await Puppeteer.LaunchAsync(new LaunchOptions
            {
                Headless = false
            });

            _currentPage = await _browser.NewPageAsync();
            await _currentPage.GoToAsync("https://aluno.uninove.br/seu/CENTRAL/aluno/");
            await _currentPage.WaitForSelectorAsync("#BtnConf");
            await _currentPage.FocusAsync("#user");
            await _currentPage.Keyboard.TypeAsync(_ra);
            await _currentPage.FocusAsync("#Password");
            await _currentPage.Keyboard.TypeAsync(_senha);
            Thread.Sleep(1000);
            await _currentPage.ClickAsync("#BtnConf");
            await _currentPage.WaitForSelectorAsync(".bem-vindo");
            Console.WriteLine("Acesso Concluido com Sucesso");
            Console.WriteLine("========================================================================================");
            #endregion

            #region Serviços
            Console.WriteLine("============================ Selecione o Serviço ====================================");
            Console.WriteLine("=====================================================================================");
            Console.WriteLine("1- Central do Aluno");
            Console.WriteLine("=====================================================================================");

            int services = int.Parse(Console.ReadLine());
            Console.WriteLine("=====================================================================================");

            switch (services)
            {
                case 1:
                    await _currentPage.ClickAsync("#btn-acessa-central");
                    await _currentPage.WaitForSelectorAsync("#content-main > div > div:nth-child(1) > div > div.m-portlet__head > div > div > h3");
                    await GetSentralAluno();
                    break;
            }
            #endregion
        }

        public async Task GetSentralAluno()
        {
            

        }
    }
}