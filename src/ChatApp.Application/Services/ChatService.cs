using SimpleChatApplication.Application.Dto;

namespace SimpleChatApplication.Application;

internal class ChatService : IChatService
{
    public async Task<List<ChatViewDto>> GetList(int userId)
    {
        return [];
    }

    public async Task<ChatDto> GetById(int chatId)
    {
        var chat = new ChatDto(
                           Id: 1,
                           CreatorId: 1,
                           Title: "Test Chat",
                           CreationTime: DateTime.UtcNow,
                           Messages: [],
                           Participants: []);

        return chat;
    }

    public async Task<int> Create(ChatCreateDto request)
    {
        return 1;
    }

    public async Task Delete(int chatId, int userId)
    {

    }
}
