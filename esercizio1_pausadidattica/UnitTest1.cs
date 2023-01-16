using Automobile.Libreria;

namespace AutoMobile_
{
    public class UnitTest1
    {
        Auto auto;


        [Fact]
        public void Test1()
        {
            auto = new Auto("123456", "DC123XD", "AUDI", "Rs3");
            auto.salitaguidatore();
            Assert.Throws<Exception>(() => auto.accendi());   //ERRORE perchè lancia l'eccezione

        }

        [Fact]
        public void Test2()
        {
            auto = new Auto("123456", "DC123XD", "AUDI", "Rs3");
            Assert.Throws<Exception>(() => auto.accendi());
        }

        [Fact]
        public void Test3()
        {
            auto = new Auto("123456", "DC123XD", "AUDI", "Rs3");
            auto.salitaguidatore();
            Assert.Throws<Exception>(() => auto.spegni());
        }

        [Fact]
        public void Test4()
        {
            auto = new Auto("123456", "DC123XD", "AUDI", "Rs3");
            Assert.Throws<Exception>(() => auto.spegni());
        }

        [Fact]
        public void Test5()
        {
            auto = new Auto("123456", "DC123XD", "AUDI", "Rs3");
            auto.impostalimite(50);
            Assert.Throws<Exception>(() => auto.impostalimite(50));   //ERRORE perchè lancia l'eccezione
        }

        [Fact]
        public void Test6()
        {
            auto = new Auto("123456", "DC123XD", "AUDI", "Rs3");
            Assert.Throws<Exception>(() => auto.impostalimite(0));
        }

        [Fact]
        public void Test7()
        {
            auto = new Auto("123456", "DC123XD", "AUDI", "Rs3");
            auto.acceleratore(50);
            auto.salitaguidatore();
            Assert.Throws<Exception>(() => auto.acceleratore(50));
        }

        [Fact]
        public void Test8()
        {
            auto = new Auto("123456", "DC123XD", "AUDI", "Rs3");
            auto.acceleratore(100);
            auto.salitaguidatore();
            Assert.Throws<Exception>(() => auto.acceleratore(100));   //ERRORE perchè sopra limite impostato
        }

        [Fact]
        public void Test9()
        {
            auto = new Auto("123456", "DC123XD", "AUDI", "Rs3");
            auto.salitaguidatore();
            Assert.Throws<Exception>(() => auto.acceleratore(0));   //GIUSTA perchè sala il guidatore ma non accellera
        }

        [Fact]
        public void Test10()
        {
            auto = new Auto("123456", "DC123XD", "AUDI", "Rs3");
            auto.acceleratore(50);
            Assert.Throws<Exception>(() => auto.acceleratore(50));   //ERRORE perchè non si può accellerare senza guidatore
        }

        [Fact]
        public void Test11()
        {
            auto = new Auto("123456", "DC123XD", "AUDI", "Rs3");
            auto.decelerazione(30);
            auto.salitaguidatore();
            Assert.Throws<Exception>(() => auto.decelerazione(30));   //ERRORE perchè passa all'eccezione
        }

        [Fact]
        public void Test12()
        {
            auto = new Auto("123456", "DC123XD", "AUDI", "Rs3");
            auto.decelerazione(100);
            auto.salitaguidatore();
            Assert.Throws<Exception>(() => auto.decelerazione(100));   //ERRORE perchè non si può decellerare più di della velocità totale
        }

        [Fact]
        public void Test13()
        {
            auto = new Auto("123456", "DC123XD", "AUDI", "Rs3");
            auto.salitaguidatore();
            Assert.Throws<Exception>(() => auto.decelerazione(0));
        }

        [Fact]
        public void Test14()
        {
            auto = new Auto("123456", "DC123XD", "AUDI", "Rs3");
            auto.decelerazione(50);
            Assert.Throws<Exception>(() => auto.decelerazione(50));   //ERRORE perchè non si può decellerare senza guidatore
        }

        [Fact]
        public void Test15()
        {
            auto = new Auto("123456", "DC123XD", "AUDI", "Rs3");
            auto.salitaguidatore();
            auto.impostalimite(50);
            auto.acceleratore(100);
            Assert.True(auto.ottieniinfrazioni()==1);
        }

        [Fact]
        public void Test16()
        {
            auto = new Auto("123456", "DC123XD", "AUDI", "Rs3");
            auto.salitapasseggero(1);
            Assert.Throws<Exception>(() => auto.salitapasseggero(1));   //OK
        }

        [Fact]
        public void Test17()
        {
            auto = new Auto("123456", "DC123XD", "AUDI", "Rs3");
            auto.salitapasseggero(0);
            Assert.Throws<Exception>(() => auto.salitapasseggero(0));   //ERRORE, nessun passeggero che sale
        }

        [Fact]
        public void Test18()
        {
            auto = new Auto("123456", "DC123XD", "AUDI", "Rs3");
            auto.salitapasseggero(4);
            Assert.Throws<Exception>(() => auto.salitapasseggero(4));   //OK
        }

        [Fact]
        public void Test19()
        {
            auto = new Auto("123456", "DC123XD", "AUDI", "Rs3");
            auto.salitapasseggero(7);
            Assert.Throws<Exception>(() => auto.salitapasseggero(7));   //ERRORE, troppi passeggeri
        }

        [Fact]
        public void Test20()
        {
            auto = new Auto("123456", "DC123XD", "AUDI", "Rs3");
            auto.acceleratore(10);
            auto.salitapasseggero(2);
            Assert.Throws<Exception>(() => auto.salitapasseggero(2));   //ERRORE, la macchina non è ferma, lancia l'eccezione
        }

        [Fact]
        public void Test21()
        {
            auto = new Auto("123456", "DC123XD", "AUDI", "Rs3");
            auto.discesapasseggeri(2);
            Assert.Throws<Exception>(() => auto.discesapasseggeri(2));   //OK
        }

        [Fact]
        public void Test22()
        {
            auto = new Auto("123456", "DC123XD", "AUDI", "Rs3");
            auto.discesapasseggerosingolo();
            Assert.Throws<Exception>(() => auto.discesapasseggerosingolo());   //ERRORE, nessun passeggero che scende
        }

        [Fact]
        public void Test23()
        {
            auto = new Auto("123456", "DC123XD", "AUDI", "Rs3");
            auto.discesapasseggeri(4);
            Assert.Throws<Exception>(() => auto.discesapasseggeri(4));   //OK
        }

        [Fact]
        public void Test24()
        {
            auto = new Auto("123456", "DC123XD", "AUDI", "Rs3");
            auto.discesapasseggeri(7);
            Assert.Throws<Exception>(() => auto.discesapasseggeri(7));   //ERRORE, troppi passeggeri
        }

        [Fact]
        public void Test25()
        {
            auto = new Auto("123456", "DC123XD", "AUDI", "Rs3");
            auto.acceleratore(10);
            auto.discesapasseggeri(2);
            Assert.Throws<Exception>(() => auto.discesapasseggeri(2));   //ERRORE, la macchina non è ferma, lancia l'eccezione
        }
    }
}