using System.Runtime.InteropServices;

Clown oneClown = new Clown();
oneClown.Name = "Boffo";
oneClown.Height = 14;
oneClown.WhoAreYou();      // My name is _______ and I'm ____ inches tall.

Clown anotherClown = new Clown();
anotherClown.Name = "Biff";
anotherClown.Height = 16;
anotherClown.WhoAreYou();  // My name is _______ and I'm ____ inches tall.

Clown clown3 = new Clown();
clown3.Name = anotherClown.Name;
clown3.Height = oneClown.Height - 3;
clown3.WhoAreYou();        // My name is _______ and I'm ____ inches tall.

anotherClown.Height *= 2;
anotherClown.WhoAreYou();  // My name is _______ and I'm ____ inches tall.