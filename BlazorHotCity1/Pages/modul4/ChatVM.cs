namespace BlazorHotCity1.Pages.modul4
{
    public class ChatVM
    {
        public Action OnChat;
        public List<Nachrichten> NachrichtenListe { get; set; } = new List<Nachrichten>();
        public void Add(string msg)
        {
            NachrichtenListe.Add(new Nachrichten() { Text = msg });
            OnChat?.Invoke();
        }
    }
}
