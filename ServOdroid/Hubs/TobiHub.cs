using Manager_Tobi;
using Microsoft.AspNet.SignalR;

namespace ServOdroid
{
    public class TobiHub : Hub
    {
        #region Attribute
        private static Tobi _tobi;
        private static bool _displaySentense = false;
        private static string _htmlResult;
        private static string _htmlSentenseDetail;
        #endregion

        #region Properties
        public static string HtmlSentenseDetail
        {
            get { return _htmlSentenseDetail; }
            set { _htmlSentenseDetail = value; }
        }
        public static string HtmlResult
        {
            get { return _htmlResult; }
            set { _htmlResult = value; }
        }
        public static bool DisplaySentense
        {
            get { return _displaySentense; }
            set { _displaySentense = value; }
        }
        public static Tobi TobiInstance
        {
            get { return _tobi; }
        }
        #endregion

        //#region Constructor
        //public TobiHub(string name, string message)
        //{
        //    Clients.All.addNewMessageToPage(name, message);
        //}
        //#endregion

        #region Methods public
        public void Send(string name, string message)
        {
            // Call the addNewMessageToPage method to update clients.
            string messageHisto = message + "\r\n";
            Clients.All.addNewUserMessageToPage(messageHisto);
            Clients.All.reflexion(true);
            GetAnswer(message);

            Clients.All.addNewMessageToPage(name, message);
        }
        public void SwitchDisplay()
        {
            _displaySentense = !_displaySentense;
            if (_displaySentense)
            {
                Clients.All.resultToDisplay(_htmlSentenseDetail, "Afficher le résultat de la recherche");
            }
            else
            {
                Clients.All.resultToDisplay(_htmlResult, "Afficher analyse des phrases");
            }
        }
        #endregion

        #region Methods private
        private void InitTobi()
        {
            _tobi = new Tobi(LANGAGE.FR);
            _tobi.Answer += _tobi_Answer;
        }
        private void GetAnswer(string question)
        {
            _htmlSentenseDetail = "<p id='actionLabel'>Action à faire : Analyse de la phrase.</p>";
            Clients.All.resultToDisplay(string.Empty, _htmlSentenseDetail);
            if (_tobi == null) InitTobi();
            _tobi.Ear(question);
        }
        #endregion  

        #region Event
        private void _tobi_Answer(string msg)
        {
            //Clients.All.reflexion(false);
            Clients.All.addNewTobiMessageToPage(msg + ".\r\n");
            _htmlResult = _tobi.Cognitor.Result == null ? string.Empty : _tobi.Cognitor.Result.ToString();
            _htmlSentenseDetail = _tobi.Cognitor.ActionLabel;
            _htmlSentenseDetail += _tobi.QuestionParsedHtml == null ? null : _tobi.QuestionParsedHtml.ToString();
            Clients.All.resultToDisplay(_htmlResult, _htmlSentenseDetail);
        }
        #endregion
    }
}