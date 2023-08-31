Book book = new Book("Programming notes");
List<Chapter> chapters = new List<Chapter>();

Chapter variablesChapter = new Chapter("Vars");
chapters.Add(variablesChapter);

List<Page> variablesPages = new List<Page>();
Page variablesPage = new Page(MyNotes.VariablesPageOne);
Page variablesPageTwo = new Page(MyNotes.VariablesPageTwo);
variablesPages.Add(variablesPage);
variablesPages.Add(variablesPageTwo);

variablesChapter.Pages = variablesPages;
book.Chapters = chapters;

Chapter variablesChapter2 = new Chapter("Data types");
chapters.Add(variablesChapter2);

List<Page> pages = new List<Page>();
Page variablespagethree = new Page(MyNotes.VariablesPageThree);
pages.Add(variablespagethree);

variablesChapter2.Pages = variablesPages;
book.Chapters = chapters;

book.Start();



// Ved brug af constructor chaining kan vi gøre ovenstående mere læsbart:
Book book2 = new Book("Programming notes", new List<Chapter>(){
    new Chapter("Vars", new List<Page>(){
        new Page(MyNotes.VariablesPageOne),
        new Page(MyNotes.VariablesPageTwo)
    }),
    new Chapter("Unity", new List<Page>(){
        //new Page(MyNotes.UnityPageOne),
        //new Page(MyNotes.UnityPageTwo),
        //new Page(MyNotes.UnityPageThree)
    })
});

//book2.Start();
