using System;
using System.Collections.Generic;
using System.Text;

namespace Secao6Listas {
    class Employee {
        public int id { get; private set; }
        public string name { get; set; }
        public double salary { get; set; }

        public int getId() {
            return id;
        }

        public string getName() {
            return name;
        }

        public double getSalary() {
            return salary;
        }

        public void setSalary(double _salary) {
            salary = _salary;
        }

        public void setId(int _id) {
            id = _id;
        }

        public void setName(string _name) {
            name = _name;
        }

        public void increaseSalary(double percentage) {
            salary *= 1 + (percentage / 100);
        }

        public override string ToString() {
            return getId() + ", " + getName() + ", " + getSalary().ToString("F2");
        }
    }
}
