<div align="center"><a name="readme-top"></a>

<img height="160" src="https://api.token-ai.cn/logo.png">

<h1>FastWiki</h1>

FastWiki打造企业级人工智能客服管理系统！

[![][github-contributors-shield]][github-contributors-link]
[![][github-forks-shield]][github-forks-link]
[![][github-stars-shield]][github-stars-link]
[![][github-issues-shield]][github-issues-link]
[![][github-license-shield]][github-license-link]

[Changelog](./CHANGELOG.md) · [Report Bug][github-issues-link] · [Request Feature][github-issues-link]

![](https://raw.githubusercontent.com/andreasbm/readme/master/assets/lines/rainbow.png)

</div>

[npm-release-shield]: https://img.shields.io/npm/v/@lobehub/chat?color=369eff&labelColor=ffcb47&logo=npm&logoColor=white&style=flat-square

[npm-release-link]: https://www.npmjs.com/package/@lobehub/chat

[github-releasedate-shield]: https://img.shields.io/github/release-date/AIDotNet/fast-wiki?color=8ae8ff&labelColor=ffcb47&style=flat-square

[github-releasedate-link]: https://github.com/AIDotNet/fast-wiki/releases

[github-action-test-shield]: https://img.shields.io/github/actions/workflow/status/AIDotNet/fast-wiki/test.yml?color=8ae8ff&label=test&labelColor=ffcb47&logo=githubactions&logoColor=white&style=flat-square

[github-action-test-link]: https://github.com/AIDotNet/fast-wiki/actions/workflows/test.yml

[github-action-release-shield]: https://img.shields.io/github/actions/workflow/status/AIDotNet/fast-wiki/release.yml?color=8ae8ff&label=release&labelColor=ffcb47&logo=githubactions&logoColor=white&style=flat-square

[github-action-release-link]: https://github.com/AIDotNet/fast-wiki/actions/workflows/release.yml

[github-contributors-shield]: https://img.shields.io/github/contributors/AIDotNet/fast-wiki?color=c4f042&labelColor=ffcb47&style=flat-square

[github-contributors-link]: https://github.com/AIDotNet/fast-wiki/graphs/contributors

[github-forks-shield]: https://img.shields.io/github/forks/AIDotNet/fast-wiki?color=8ae8ff&labelColor=ffcb47&style=flat-square

[github-forks-link]: https://github.com/AIDotNet/fast-wiki/network/members

[github-stars-shield]: https://img.shields.io/github/stars/AIDotNet/fast-wiki?color=ffcb47&labelColor=ffcb47&style=flat-square

[github-stars-link]: https://github.com/AIDotNet/fast-wiki/network/stargazers

[github-issues-shield]: https://img.shields.io/github/issues/AIDotNet/fast-wiki?color=ff80eb&labelColor=ffcb47&style=flat-square

[github-issues-link]: https://github.com/AIDotNet/fast-wiki/issues

[github-license-shield]: https://img.shields.io/github/license/AIDotNet/fast-wiki?color=white&labelColor=ffcb47&style=flat-square

[github-license-link]: https://github.com/AIDotNet/fast-wiki/blob/main/LICENSE

# FastWiki

-----
Document Language: [English](README.md) | [简体中文](README-zh-cn.md)

## Introduction

This project is a high-performance knowledge base system based on the latest technology stack, designed for large-scale
information retrieval and intelligent search. Leveraging Microsoft's Semantic Kernel for deep learning and natural
language processing, combined with .NET 8 and React framework, with the backend using MasaFramework, it has implemented
an efficient, user-friendly, and scalable intelligent vector search platform. Our goal is to provide an intelligent
search solution that can understand and process complex queries, helping users quickly and accurately obtain the
information they need.

## Technology Stack

- Frontend Framework: React + LobeChat + TypeScript
- Backend Framework: MasaFramework based on .NET 8
- Implemented dynamic functions based on the JS V8 engine
- Vector Search Engine: Utilizes PostgreSQL's vector plugin to optimize search performance and also provides DISK
- Deep Learning and NLP: Microsoft's Semantic Kernel to enhance the semantic understanding capability of search
- License: Apache-2.0, encouraging community contributions and usage

## Features

- Intelligent Search: Leveraging Semantic Kernel's deep learning and natural language processing technology to
  understand complex queries and provide precise search results.
- High Performance: Optimizes vector search performance through pgsql's vector plugin, ensuring quick responses even
  with large amounts of data.
- Modern Frontend: Utilizes the React + LobeUI frontend framework, offering responsive design and user-friendly
  interfaces.
- Powerful Backend: Based on the latest .NET 8 and MasaFramework, ensuring code efficiency and maintainability.
- Open Source and Community-Driven: Adopts the Apache-2.0 license, encouraging developers and enterprises to use and
  contribute.
- Powerful dynamic JS Function and provides Monaco for convenient intelligent code suggestions.
- Powerful QA question-answer split mode for more intelligent knowledge base responses.
- Fast integration with Feishu bots.
- Fast integration with WeChat Official Accounts.
- Fast integration with enterprise projects.

## Quick Start

### Prerequisites

Ensure you have installed the .NET 8 SDK, PostgreSQL database, the PostgreSQL vector plugin, and have configured the
corresponding environments.

## Frontend

### Installation

1. Clone the repository:

```
git clone --recursive https://github.com/AIDotNet/fast-wiki.git
```

2. Install node.js, the latest version (https://nodejs.p2hp.com/).

3. Delete the package-lock.json file and node_modules directory in the web directory.

4. Run the following commands in the web directory:

```
npm i
npm run build
```

5. Copy the contents under the dist directory in the web directory to the "
   \fast-wiki\src\Service\FastWiki.Service\wwwroot" directory (create one if wwwroot doesn't exist).

## Backend

1. Install dependencies:

Execute the following in the project root directory:

```
cd src/Service/FastWiki.Service
dotnet restore
```

2. Database Configuration:

Ensure your PostgreSQL database is running properly and has the necessary databases created. Modify the database
connection string in `appsettings.json` according to your configuration.

### Running

Execute the following in the project root directory:

```
dotnet run
```

This will start the backend service. Visit http://localhost:5124/ to see the frontend page.

Default username and password: admin Aa123456

## Environment Variables

FastWikiService environment variables:

- QUANTIZE_MAX_TASK: Maximum concurrency of quantization tasks, default is 3
- OPENAI_CHAT_ENDPOINT: Address of the OpenAI API
- OPENAI_CHAT_EMBEDDING_ENDPOINT: Address of the Embedding API
- OPENAI_CHAT_TOKEN: Token for the OpenAI API
- OPENAI_EMBEDDING_TOKEN: Token for Embedding, default is empty, if empty, the conversation Token is used
- DEFAULT_TYPE: Business database type default sqlite|[pgsql|postgres]
- DEFAULT_CONNECTION: Business database connection string
- WIKI_TYPE: Wiki database type default disk|[pgsql|postgres]
- WIKI_CONNECTION: Wiki database connection string (if disk, it should be a directory)

## Technical Communication

![Group Chat QR Code](img/wechat.png)

## Contribution Guidelines

We welcome all forms of contributions, whether it's feature requests, bug reports, code submissions, documentation, or
any other type of support. Please refer to `CONTRIBUTING.md` to get started.

## License

This project is licensed under Apache-2.0. See the [LICENSE](LICENSE) file for details.
