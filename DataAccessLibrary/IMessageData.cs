using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
	public interface IMessageData
	{
		Task<List<MessageModel>> GetMessages();
		Task<List<MessageModel>> GetLastHundredMessages();
		Task CreateNewMessage(MessageModel message);
	}
}