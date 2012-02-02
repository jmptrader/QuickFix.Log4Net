namespace QuickFix.Log4Net
{
	public class Log4NetLog : Log4NetLogBase, Log
	{
		public Log4NetLog()
		{
		}

		public Log4NetLog(string sessionId) : base(sessionId)
		{
		}

		public virtual void clear()
		{
		}

		public virtual void backup()
		{
		}

		public virtual void onIncoming(string @string)
		{
			Log.Info("Incoming: " + GetMessageParsed(@string));
		}

		public virtual void onOutgoing(string @string)
		{
			Log.Info("Outgoing: " + GetMessageParsed(@string));
		}

		public virtual void onEvent(string @string)
		{
			Log.Info("Event: " + @string);
		}
	}
}