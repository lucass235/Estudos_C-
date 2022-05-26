
namespace AlunoCursos.Entites {
    class Aluno: IComparable  {
        public int code { get; set; }
        public string name { get; set; }

        public Aluno(int code, string name) {
            this.code = code;
            this.name = name;
        }

        public override bool Equals(object outhe) {
            if (outhe is Aluno) {
                Aluno aluno = outhe as Aluno;
                return this.code.Equals(aluno.code);
            }
            return false;
        }
        public override int GetHashCode() {
            return this.code.GetHashCode();
        }

        public override string ToString() {
            return $"Aluno(a) {this.name} de código: {this.code} \n";
        }

        public int CompareTo(object obj) {
            Aluno aluno = obj as Aluno;
            return this.code.CompareTo(aluno.code);
        }

    }
}
