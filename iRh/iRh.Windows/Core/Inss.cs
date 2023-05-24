namespace iRh.Windows.Core

{
    public static class Inss
    {
        const double FaixaSalarial1 = 1320.00;
        const double FaixaSalarial2 = 2571.29;
        const double FaixaSalarial3 = 3856.94;
        const double FaixaSalarial4 = 7507.49;
        //função retorno nome()
        public static double Calcula(double salario)
        {
            

            double valorInss = 0;

            if (salario <= FaixaSalarial1)
            {
                valorInss = CalculaFaixa1(salario);
                               
            }
            else if(salario <= FaixaSalarial2)
            {

                var descontoFaixa1 = CalculaFaixa1(salario);
                valorInss = (salario - FaixaSalarial1) + descontoFaixa1;
            }
            else if(salario <= FaixaSalarial3)
            {
                var descontoFaixa1 = CalculaFaixa1(salario);
                var descontoFaixa2 = 0.09 * (FaixaSalarial2 - FaixaSalarial1);
                valorInss = 12 / 100 * (salario - FaixaSalarial2) + descontoFaixa1 + descontoFaixa2;
            }
            else if(salario <= FaixaSalarial4)
            {
                var descontoFaixa1 = CalculaFaixa1(salario);
                var descontoFaixa2 = CalculoFaixa2(salario);
                var descontoFaixa3 = CalculoFaixa3(salario);
                valorInss = 0.14 * (salario - FaixaSalarial3) + descontoFaixa1 + descontoFaixa2 + descontoFaixa3;  
            }
            else
            {
                var descontoFaixa1 = CalculaFaixa1(salario);
                var descontoFaixa2 = CalculoFaixa2(salario);
                var descontoFaixa3 = CalculoFaixa3(salario);
                valorInss = 0.14 * (FaixaSalarial4 - FaixaSalarial3) + descontoFaixa1 + descontoFaixa2 + descontoFaixa3;
            }
            return valorInss;
        }
        private static double CalculaFaixa1(double salario)
        {
            return (0.075 * FaixaSalarial1);
        }
        private static double CalculoFaixa2(double salario)
        {
            return 0.09 * (FaixaSalarial2 - FaixaSalarial1);
        }
        private static double CalculoFaixa3(double salario)
        {
            return 0.12 * (FaixaSalarial3 - FaixaSalarial2);
        }
    }
}
