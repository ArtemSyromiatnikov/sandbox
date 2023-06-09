Person ira = new Person("Iryna", 2005);
Person artem = new Person("Artem", 1991);

artem.Age = 48;
ira.Age = -80;

//ira.Age = -80 ; // Calls 'set'
//Console.WriteLine(ira.Age); // Calls 'get'

ira.CallMe();
artem.CallMe();


class Person {
    public string name;
    private int _age;

    public int Age {
        get {
            return _age;
        }
        set {
            if (value < 0) {
                _age = 0;
            } else if (value > 120) {
                _age = 120;
            } else {
                _age = value;
            }
        }
    }

    public Person(string name, int birthYear) {
        this.name = name;
        this._age = 2023 - birthYear;
    }

    public void CallMe() {
        Console.WriteLine($"Calling {name} (age: {_age})");
    }
}
