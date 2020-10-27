using System;
using Terminal.Gui;

namespace PokeApi.UI
{
    public class GuiMain
    {
        public GuiMain()
        {

        }

        public void Start()
        {
            Application.Init();
            var menu = new MenuBar(new MenuBarItem[] {
            new MenuBarItem ("_File", new MenuItem [] {
                new MenuItem ("_Quit", "", () => {
                    Application.RequestStop ();
                    })
                }),
            });

            var win = new Window("Hello")
            {
                X = 0,
                Y = 1,
                Width = Dim.Fill(),
                Height = Dim.Fill() - 1
            };
            var textfield = new TextField("ditto")
            {
                X = Pos.Center(),
                Y = Pos.Center(),
                Width = 10
            };
            var button = new Button("Get")
            {
                X = Pos.Center(),
                Y = Pos.Center() + 1
            };
            button.Clicked += Button_Clicked;
            win.Add(textfield);
            win.Add(button);

            // Add both menu and win in a single call
            Application.Top.Add(menu, win);
            Application.Run();
        }

        private void Button_Clicked()
        {
            
        }
    }
}
