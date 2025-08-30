# Sudoku Solver - Un Assistente Interattivo in .NET 8

Un'applicazione web costruita con ASP.NET Core MVC che non solo risolve qualsiasi puzzle di Sudoku, ma offre anche un'interfaccia utente pulita e interattiva per un'esperienza completa.

![Screenshot dell'Applicazione](./docs/screenshot.png)

<h2 style="border-bottom: none;">🎯 A Proposito di Questo Progetto</h2>

Questo progetto è nato come un'esplorazione dell'algoritmo di backtracking e si è evoluto in un'applicazione web full-stack. L'obiettivo era creare uno strumento non solo funzionale, ma anche ben progettato, robusto e con un'ottima esperienza utente, dimostrando competenze in tutto lo stack tecnologico .NET.

<h2 style="border-bottom: none;">✨ Funzionalità Attuali</h2>

*   **Risoluzione Istantanea:** Utilizza un efficiente algoritmo di backtracking ricorsivo per risolvere qualsiasi puzzle valido.
*   **Validazione della Griglia Iniziale:** Controlla la validità del puzzle inserito dall'utente prima di tentare la risoluzione, fornendo un feedback immediato in caso di input non valido.
*   **Puzzle di Esempio Casuali:** Carica puzzle con un click per tre livelli di difficoltà (Facile, Medio, Difficile), con diversi esempi per ogni livello.
*   **Interfaccia Utente Curata:**
    *   Feedback visivo per l'utente (spinner di caricamento, messaggi di successo/errore).
    *   Layout professionale con Navbar, Footer e Favicon personalizzata.
    *   Pulsante "Azzera" per pulire la griglia.
*   **Gestione Errori Professionale:** Pagine di errore personalizzate per URL non validi (404) e crash del server (500).

<h2 style="border-bottom: none;">🛠️ Tecnologie Utilizzate</h2>

*   **Backend:** C#, .NET 8, ASP.NET Core MVC
*   **Frontend:** HTML5, CSS3, JavaScript (vanilla)
*   **Framework CSS:** Bootstrap
*   **Architettura:** Model-View-Controller (MVC)

<h2 style="border-bottom: none;">🚀 Come Eseguirlo in Locale</h2>

1.  Clona il repository: `git clone https://github.com/GMengo/SudokuSolver.git`
2.  Apri la soluzione (`.sln`) con Visual Studio 2022 o versioni successive.
3.  Assicurati di avere l'.NET 8 SDK installato.
4.  Avvia il progetto (premendo F5 o `dotnet run` dal terminale).