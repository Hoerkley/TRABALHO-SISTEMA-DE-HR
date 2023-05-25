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

                var desconto = CalculaFaixa(salario);
                var desconto2 = CalculaFaixa2(salario) + desconto;
                valorInss = desconto2;             
            }
            else if(salario <= FaixaSalarial3)
            {
                var desconto = CalculaFaixa(salario);
                var desconto2 = CalculaFaixa1(salario);
                var descoto3 = CalculaFaixa2(salario);
                var desconto4= CalculoFaixa3(salario) + desconto;
                valorInss = desconto4;
            }
            else if(salario <= FaixaSalarial4)
            {
                var desconto = CalculaFaixa(salario);
                var desconto2 = CalculaFaixa1(salario);
                var descoto3 = CalculaFaixa2(salario);
                var desconto4 = CalculoFaixa3(salario);
                var desconto5 = CalculaFaixa4(salario) + desconto;
                valorInss = desconto5;
            }
            else
            {
                var desconto = CalculaFaixa(salario);
                var desconto2 = CalculaFaixa1(salario);
                var descoto3 = CalculaFaixa2(salario);
                var desconto4 = CalculoFaixa3(salario);
                var desconto5 = CalculaFaixa4(salario) + desconto + desconto2 + descoto3 + desconto4;
                valorInss = desconto5;
            }
            return valorInss;
        }
        private static double CalculaFaixa(double salario)
        {
            return (0.075 * FaixaSalarial1);
        }
        private static double CalculaFaixa1(double salario)
        {
            return (0.075 * salario);
        }
        private static double CalculaFaixa2(double salario)
        {
            return 0.09 * (FaixaSalarial2 - FaixaSalarial1);
        }
        private static double CalculoFaixa3(double salario)
        {
            return 0.12 * (FaixaSalarial3 - FaixaSalarial2);
        }
        private static double CalculaFaixa4(double salario)
        {
            return 0.14 * (FaixaSalarial4 - FaixaSalarial3);
        }
    }
}
