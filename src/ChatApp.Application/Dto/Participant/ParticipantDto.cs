﻿namespace SimpleChatApplication.Application.Dto;

public record ParticipantDto(
    int ChatId,
    int UserId,
    DateTime JoinedTime
);
