// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace vxTel.Unit.Test.Feature
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class EuEnquantoUsuarioQueroSaberQuantoIreiPagarEmUmaLigacao_Feature : Xunit.IClassFixture<EuEnquantoUsuarioQueroSaberQuantoIreiPagarEmUmaLigacao_Feature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "CalcularValorLigacao.feature"
#line hidden
        
        public EuEnquantoUsuarioQueroSaberQuantoIreiPagarEmUmaLigacao_Feature(EuEnquantoUsuarioQueroSaberQuantoIreiPagarEmUmaLigacao_Feature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-br"), "Eu, enquanto usuário quero saber quanto irei pagar em uma ligação.", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="Calcular o valor de uma ligação com o ddd origem 11 e destino 16 sem nenhum plano" +
            " FaleMais da VxTel")]
        [Xunit.TraitAttribute("FeatureTitle", "Eu, enquanto usuário quero saber quanto irei pagar em uma ligação.")]
        [Xunit.TraitAttribute("Description", "Calcular o valor de uma ligação com o ddd origem 11 e destino 16 sem nenhum plano" +
            " FaleMais da VxTel")]
        [Xunit.TraitAttribute("Category", "basic")]
        public virtual void CalcularOValorDeUmaLigacaoComODddOrigem11EDestino16SemNenhumPlanoFaleMaisDaVxTel()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Calcular o valor de uma ligação com o ddd origem 11 e destino 16 sem nenhum plano" +
                    " FaleMais da VxTel", null, new string[] {
                        "basic"});
#line 6
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
testRunner.Given("Quando eu informar corretamente os dados de origem|destino|duracao|plano 11|16|20" +
                    "|0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dados ");
#line 8
testRunner.Then("O resultado do calculo deve ser 38,00", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Calcular o valor de uma ligação com o ddd origem 11 e destino 17 sem nenhum plano" +
            " FaleMais da VxTel")]
        [Xunit.TraitAttribute("FeatureTitle", "Eu, enquanto usuário quero saber quanto irei pagar em uma ligação.")]
        [Xunit.TraitAttribute("Description", "Calcular o valor de uma ligação com o ddd origem 11 e destino 17 sem nenhum plano" +
            " FaleMais da VxTel")]
        public virtual void CalcularOValorDeUmaLigacaoComODddOrigem11EDestino17SemNenhumPlanoFaleMaisDaVxTel()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Calcular o valor de uma ligação com o ddd origem 11 e destino 17 sem nenhum plano" +
                    " FaleMais da VxTel", null, ((string[])(null)));
#line 10
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 11
testRunner.Given("Quando eu informar corretamente os dados de origem|destino|duracao|plano 11|17|80" +
                    "|0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dados ");
#line 12
testRunner.Then("O resultado do calculo deve ser 136,00", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Calcular o valor de uma ligação com o ddd origem 18 e destino 11 sem nenhum plano" +
            " FaleMais da VxTel")]
        [Xunit.TraitAttribute("FeatureTitle", "Eu, enquanto usuário quero saber quanto irei pagar em uma ligação.")]
        [Xunit.TraitAttribute("Description", "Calcular o valor de uma ligação com o ddd origem 18 e destino 11 sem nenhum plano" +
            " FaleMais da VxTel")]
        public virtual void CalcularOValorDeUmaLigacaoComODddOrigem18EDestino11SemNenhumPlanoFaleMaisDaVxTel()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Calcular o valor de uma ligação com o ddd origem 18 e destino 11 sem nenhum plano" +
                    " FaleMais da VxTel", null, ((string[])(null)));
#line 14
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 15
testRunner.Given("Quando eu informar corretamente os dados de origem|destino|duracao|plano 18|11|20" +
                    "0|0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dados ");
#line 16
testRunner.Then("O resultado do calculo deve ser 380,00", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Calcular o valor de uma ligação com o ddd origem 18 e destino 17 sem nenhum plano" +
            " FaleMais da VxTel")]
        [Xunit.TraitAttribute("FeatureTitle", "Eu, enquanto usuário quero saber quanto irei pagar em uma ligação.")]
        [Xunit.TraitAttribute("Description", "Calcular o valor de uma ligação com o ddd origem 18 e destino 17 sem nenhum plano" +
            " FaleMais da VxTel")]
        public virtual void CalcularOValorDeUmaLigacaoComODddOrigem18EDestino17SemNenhumPlanoFaleMaisDaVxTel()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Calcular o valor de uma ligação com o ddd origem 18 e destino 17 sem nenhum plano" +
                    " FaleMais da VxTel", null, ((string[])(null)));
#line 18
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 19
testRunner.Given("Quando eu informar corretamente os dados de origem|destino|duracao|plano 18|17|10" +
                    "0|0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dados ");
#line 20
testRunner.Then("O resultado do calculo deve ser 0,00", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Calcular o valor de uma ligação com o ddd origem 11 e destino 16 com o plano Fale" +
            "Mais30 VxTel")]
        [Xunit.TraitAttribute("FeatureTitle", "Eu, enquanto usuário quero saber quanto irei pagar em uma ligação.")]
        [Xunit.TraitAttribute("Description", "Calcular o valor de uma ligação com o ddd origem 11 e destino 16 com o plano Fale" +
            "Mais30 VxTel")]
        public virtual void CalcularOValorDeUmaLigacaoComODddOrigem11EDestino16ComOPlanoFaleMais30VxTel()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Calcular o valor de uma ligação com o ddd origem 11 e destino 16 com o plano Fale" +
                    "Mais30 VxTel", null, ((string[])(null)));
#line 22
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 23
testRunner.Given("Quando eu informar corretamente os dados de origem|destino|duracao|plano 11|16|20" +
                    "|1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dados ");
#line 24
testRunner.Then("O resultado do calculo deve ser 0,00", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Calcular o valor de uma ligação com o ddd origem 11 e destino 17 com o plano Fale" +
            "Mais60 VxTel")]
        [Xunit.TraitAttribute("FeatureTitle", "Eu, enquanto usuário quero saber quanto irei pagar em uma ligação.")]
        [Xunit.TraitAttribute("Description", "Calcular o valor de uma ligação com o ddd origem 11 e destino 17 com o plano Fale" +
            "Mais60 VxTel")]
        public virtual void CalcularOValorDeUmaLigacaoComODddOrigem11EDestino17ComOPlanoFaleMais60VxTel()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Calcular o valor de uma ligação com o ddd origem 11 e destino 17 com o plano Fale" +
                    "Mais60 VxTel", null, ((string[])(null)));
#line 26
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 27
testRunner.Given("Quando eu informar corretamente os dados de origem|destino|duracao|plano 11|17|80" +
                    "|2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dados ");
#line 28
testRunner.Then("O resultado do calculo deve ser 37,40", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Calcular o valor de uma ligação com o ddd origem 18 e destino 11 com o plano x Fa" +
            "leMais120 VxTel")]
        [Xunit.TraitAttribute("FeatureTitle", "Eu, enquanto usuário quero saber quanto irei pagar em uma ligação.")]
        [Xunit.TraitAttribute("Description", "Calcular o valor de uma ligação com o ddd origem 18 e destino 11 com o plano x Fa" +
            "leMais120 VxTel")]
        public virtual void CalcularOValorDeUmaLigacaoComODddOrigem18EDestino11ComOPlanoXFaleMais120VxTel()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Calcular o valor de uma ligação com o ddd origem 18 e destino 11 com o plano x Fa" +
                    "leMais120 VxTel", null, ((string[])(null)));
#line 30
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 31
testRunner.Given("Quando eu informar corretamente os dados de origem|destino|duracao|plano 18|11|20" +
                    "0|3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dados ");
#line 32
testRunner.Then("O resultado do calculo deve ser 167,20", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Calcular o valor de uma ligação com o ddd origem 18 e destino 17 com o plano x Fa" +
            "leMais30 VxTel")]
        [Xunit.TraitAttribute("FeatureTitle", "Eu, enquanto usuário quero saber quanto irei pagar em uma ligação.")]
        [Xunit.TraitAttribute("Description", "Calcular o valor de uma ligação com o ddd origem 18 e destino 17 com o plano x Fa" +
            "leMais30 VxTel")]
        public virtual void CalcularOValorDeUmaLigacaoComODddOrigem18EDestino17ComOPlanoXFaleMais30VxTel()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Calcular o valor de uma ligação com o ddd origem 18 e destino 17 com o plano x Fa" +
                    "leMais30 VxTel", null, ((string[])(null)));
#line 34
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 35
testRunner.Given("Quando eu informar corretamente os dados de origem|destino|duracao|plano 18|17|10" +
                    "0|1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dados ");
#line 36
testRunner.Then("O resultado do calculo deve ser 0,00", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                EuEnquantoUsuarioQueroSaberQuantoIreiPagarEmUmaLigacao_Feature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                EuEnquantoUsuarioQueroSaberQuantoIreiPagarEmUmaLigacao_Feature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion