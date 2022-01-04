# Sito Ticketing BBC

Per questo progetto ho utilizzato `Blazor Server` come framework .NET per lo sviluppo web e `SQL Server` per la gestione dei dati.

La maggior parte dei componenti sono presi dalla libreria [Mudblazor](https://github.com/MudBlazor/MudBlazor) qui trovate l'[API](https://dev.mudblazor.com/)

Il progetto è diviso in due soluzioni 

- BbcSrUI -> che contiene il progetto per esteso 
- DataAccessLibrary -> una libreria d'interfaccia per le query

### Configurazione per il rilascio

1. Inserire la ConnectionString al db di produzione.
2. Aggiungere la tabella Banner al db di produzione per il corretto inserimento dei banner nella dashboard. 
3. Migrare le tabelle per il controllo dell'Identity su db di produzione.

#### 1 Inserire la ConnectionString al db di produzione.
Per inserire la ConnectionString apri il file `appsettings.json`

```markdown
BbcSrUI
    └── appsettings.json
```

e modifica il la stringa come segue:

```json
{
  "ConnectionStrings": {
    "Default": "inserisci la stringa qui"
  }
```

#### 2. Aggiungere la tabella Banner al db di produzione per il corretto inserimento dei banner nella dashboard. 

Per inserire nuovi banner nella dashboard creare la seguente tabella
```sql
CREATE TABLE [dbo].[Banner] (
    [Id]          INT           NOT NULL,
    [name]        VARCHAR (150) NOT NULL,
    [sourceImage] VARCHAR (150) NOT NULL,
    [LinkToSite]  VARCHAR (200) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
```
Nella tabella banner troviamo:
- `Id` di riferimento del banner 
- `name` il nome di riferimento del banner 
- `sourceImage` è il link all'immagine che verrà visualizzata nel carusel sulla dashboard si consiglia un forrmato 300x200px
- `linkToSite` è il link dove viene mandato l'utente quando clicca sul banner

Una volta completato i banner inseriti verranno visualizzati nel carusel sulla dashboard.

#### 3. Migrare le tabelle per il controllo dell'Identity su db di produzione.

Per poter utilizzare l'Identity framework di Microsoft bisogna eseguire la seguente procedura per effettuare la migrazione di alcune tabelle sul db di produzione dove 
verranno salvati i dati degli user per authorization/authentication.

**ATTENZIONE!**
Prima di migrare le tabelle controllare le password dei vari utenti che verranno inserite automaticamente nella tabella in modo programmatico.

Per visualizzare le password e gli user che saranno creati alla migrazione e per poterli modificare aprite il file `AppIdentityDbContextSeed.cs`

```markdown
BbcSrUI
    └── Data
        └── Models
            └── AppIdentityDbContextSeed.cs
```

La nuova password inserita **deve** comprendere un carattere maiuscolo, uno speciale e un numero, in caso contrario non verrà inserita nella tabella.

Per effettuare la migrazione aprire la `Packege Manager Console` ed eseguire il seguente comando
```console
PM> Update-Database
```

Gli utenti sono ora registrati 

