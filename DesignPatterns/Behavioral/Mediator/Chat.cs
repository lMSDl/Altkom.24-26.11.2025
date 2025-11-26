namespace DesignPatterns.Behavioral.Mediator
{
    internal class Chat : IMediator
    {
        private readonly ICollection<ChatMemeber> _members = [];
        public void Join(ChatMemeber member)
        {
            if (!_members.Contains(member))
                _members.Add(member);
        }

        public void Quit(ChatMemeber member)
        {
            if (_members.Contains(member))
                _members.Remove(member);
        }

        public void Send(ChatMemeber from, string message)
        {
            var query = _members.Where(x => from != x);
            if (from is ChatBot)
                query = query.Where(x => x is not ChatBot);
            foreach (var member in query)
            {
                member.Receive(from.Nick, message, false);
            }
        }

        public void Send(ChatMemeber from, string to, string message)
        {
            _members.FirstOrDefault(x => x.Nick == to)?.Receive(from.Nick, message, true);
        }
    }
}
