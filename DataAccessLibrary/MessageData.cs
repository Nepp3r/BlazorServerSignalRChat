using DataAccessLibrary.Models;
using System;

namespace DataAccessLibrary
{
	public class MessageData : IMessageData
	{
		private readonly ISqlDataAccess _db;

		public MessageData(ISqlDataAccess db)
		{
			_db = db;
		}
		public Task<List<MessageModel>> GetMessages()
		{
			string sql = "SELECT * FROM dbo.Messages";

			return _db.LoadData<MessageModel, dynamic>(sql, new { });
		}

		public Task CreateNewMessage(MessageModel message)
		{
			string sql = @"INSERT INTO dbo.Messages (MessageText, UserName, SendTime)
							VALUES (@MessageText, @UserName, @SendTime);";
			return _db.SaveData(sql, message);
		}

        public Task<List<MessageModel>> GetLastHundredMessages()
        {
			string sql = @"SELECT TOP 100 *
						   FROM dbo.Messages
						   ORDER BY Id DESC";
			return _db.LoadData<MessageModel, dynamic>(sql, new { });
        }
    }
}
