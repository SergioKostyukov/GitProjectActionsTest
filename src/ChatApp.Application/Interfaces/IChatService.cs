﻿using SimpleChatApplication.Application.Dto;

namespace SimpleChatApplication.Application;

public interface IChatService
{
    Task<List<ChatViewDto>> GetList(int userId);
    Task<ChatDto> GetById(int chatId);
    Task<int> Create(ChatCreateDto request);
    Task Delete(int chatId, int userId);
}
