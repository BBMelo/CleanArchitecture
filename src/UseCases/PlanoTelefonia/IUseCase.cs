namespace vxTel.UseCase.PlanoTelefonia
{
    internal interface IRequestHandler<in TRequest1, in TRequest2, in TRequest3, in TRequest4, out TResponse>
    {
        TResponse Handle(TRequest1 request1, TRequest2 request2, TRequest3 request3, TRequest4 request4);
    }

    //public interface IUseCase : IDisposable
    //{
    //    Task CalcularValorLigacao(DDD oriegm, DDD destino, int minutosFalado, EPlanoTelefonia planoTelefonia);
    //}
}
