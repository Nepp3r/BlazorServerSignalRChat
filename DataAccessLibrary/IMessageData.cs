using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
	public interface IMessageData
	{
		Task<List<MessageModel>> GetMessages();
		Task CreateNewMessage(MessageModel message);
	}
}