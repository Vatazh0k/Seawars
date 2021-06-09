namespace Seawars.Domain.Models
{
    public class Game
    {
        public string CryptedGameId { get; set; }

        public Field FirstUserField { get; set; } 
        public Field SecondUserField { get; set; }

        public bool IsFirstUserMove { get; set; } = true;
        public bool IsFirstUserReadyToStartGame { get; set; }
        public bool IsSecondUserReadyToStartGame { get; set; }
        public bool IsGameOver { get; set; }
        public bool IsFirstUserWin { get; set; }
        public bool DidEnemyConnect { get; set; } = false;
        public bool IsGameWithComputer { get; set; } = true;


        public Game(string Id)
        {
            CryptedGameId = Id;

            FirstUserField = new Field();
            SecondUserField = new Field(); 
        }

        public Field this[int index]
        {
            get => index switch
            {
                1 => FirstUserField,
                2 => SecondUserField,
                { } => null
            };
        }

    }
}
