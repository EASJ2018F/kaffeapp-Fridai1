namespace kaffe
{
    public class FlatWhite : Kaffe, Imælk
    {
        private int _pris;
        private int _mIMælk;
        private string _styrke;

        public FlatWhite()
        {
            _pris = 45;
            _mIMælk = 160;
            _styrke = "mild";
        }

        public override int Pris()
        {
            return _pris;
        }

        public string Styrke()
        {
            return _styrke;
        }

        public int MlMælk()
        {
            return _mIMælk;
        }
    }
}