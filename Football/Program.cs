namespace Football
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<FootballPlayer> p1 = new List<FootballPlayer>();
            Goalkeeper g1 = new Goalkeeper("Ivan", 25, 1.90, 1);
            p1.Add(g1);
            Defender d11 = new Defender("Petur", 23, 1.87, 2);
            p1.Add(d11);
            Defender d12 = new Defender("Petur", 23, 1.87, 2);
            p1.Add(d12);
            Defender d13 = new Defender("Petur", 23, 1.87, 2);
            p1.Add(d13);
            Defender d14 = new Defender("Petur", 23, 1.87, 2);
            p1.Add(d14);
            Midfield m11 = new Midfield("Petur", 23, 1.87, 2);
            p1.Add(m11);
            Midfield m12 = new Midfield("Petur", 23, 1.87, 2);
            p1.Add(m12);
            Midfield m13 = new Midfield("Petur", 23, 1.87, 2);
            p1.Add(m13);
            Midfield m14 = new Midfield("Petur", 23, 1.87, 2);
            p1.Add(m14);
            Striker s11 = new Striker("Petur", 23, 1.87, 2);
            p1.Add(s11);
            Striker s12 = new Striker("Petur", 23, 1.87, 2);
            p1.Add(s12);
            Striker s13 = new Striker("Petur", 23, 1.87, 2);
            p1.Add(s13);
            Coach c1 = new Coach("Kosta", 55);
            Team t1 = new Team(c1, p1);

            List<FootballPlayer> p2 = new List<FootballPlayer>();
            Goalkeeper g2 = new Goalkeeper("Ivan", 25, 1.90, 1);
            p2.Add(g2);
            Defender d21 = new Defender("Petur", 23, 1.87, 2);
            p2.Add(d21);
            Defender d22 = new Defender("Petur", 23, 1.87, 2);
            p2.Add(d22);
            Defender d23 = new Defender("Petur", 23, 1.87, 2);
            p2.Add(d23);
            Defender d24 = new Defender("Petur", 23, 1.87, 2);
            p2.Add(d24);
            Midfield m21 = new Midfield("Petur", 23, 1.87, 2);
            p2.Add(m21);
            Midfield m22 = new Midfield("Petur", 23, 1.87, 2);
            p2.Add(m22);
            Midfield m23 = new Midfield("Petur", 23, 1.87, 2);
            p2.Add(m23);
            Midfield m24 = new Midfield("Petur", 23, 1.87, 2);
            p2.Add(m24);
            Striker s21 = new Striker("Petur", 23, 1.87, 2);
            p2.Add(s21);
            Striker s22 = new Striker("Petur", 23, 1.87, 2);
            p2.Add(s22);
            Striker s23 = new Striker("Petur", 23, 1.87, 2);
            p2.Add(s23);
            Coach c2 = new Coach("Kosta", 55);
            Team t2 = new Team(c2, p2);

            List<Referee> r = new List<Referee>();
            Referee r1 = new Referee("Vanko", 34);
            r.Add(r1);
            Referee r2 = new Referee("Vanko", 34);
            r.Add(r2);
            Referee r3 = new Referee("Vanko", 34);
            r.Add(r3);

            Game game1 = new Game(t1, t2, r);
        }
    }
}