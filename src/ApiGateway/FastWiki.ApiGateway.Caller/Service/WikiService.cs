﻿using FastWiki.ApiGateway.caller.Service;
using FastWiki.Service.Contracts.Wikis.Dto;
using Masa.Utils.Models;

namespace FastWiki.ApiGateway.Caller.Service;

public sealed class WikiService(ICaller caller) : ServiceBase(caller), IWikiService
{
    protected override string BaseUrl { get; set; } = "Wikis";

    public async Task CreateAsync(CreateWikiInput input)
    {
        await PostAsync(nameof(CreateAsync), input);
    }

    public async Task<WikiDto> GetAsync(long id)
    {
        return await GetAsync<WikiDto>(nameof(GetAsync) + "/" + id);
    }

    public async Task<PaginatedListBase<WikiDto>> GetWikiListAsync(string keyword, int page, int pageSize)
    {
        return await GetAsync<PaginatedListBase<WikiDto>>(nameof(GetWikiListAsync), new Dictionary<string, string>()
        {
            { "keyword", keyword },
            { "page", page.ToString() },
            { "pageSize", pageSize.ToString() }
        });
    }

    public async Task RemoveAsync(long id)
    {
        await DeleteAsync(nameof(RemoveAsync) + "/" + id);
    }

    public async Task CreateWikiDetailsAsync(CreateWikiDetailsInput input)
    {
        await PostAsync(nameof(CreateWikiDetailsAsync), input);
    }

    public async Task<PaginatedListBase<WikiDetailDto>> GetWikiDetailsAsync(long wikiId, string keyword, int page,
        int pageSize)
    {
        return await GetAsync<PaginatedListBase<WikiDetailDto>>(nameof(GetWikiDetailsAsync),
            new Dictionary<string, string>()
            {
                { "wikiId", wikiId.ToString() },
                { "keyword", keyword },
                { "page", page.ToString() },
                { "pageSize", pageSize.ToString() }
            });
    }

    public async Task RemoveDetailsAsync(long id)
    {
        await DeleteAsync(nameof(RemoveDetailsAsync) + "/" + id);
    }
}