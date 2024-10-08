public class Dungeon
{
    private Walls[][] map =  {
        // 1
        new Walls[] {
            new(0, 1, 1, 0), new(0, 1, 0, 1), new(0, 1, 0, 1), new(0, 1, 0, 1), new(0, 1, 0, 0),
            new(0, 1, 0, 0), new(0, 1, 0, 1), new(0, 1, 0, 1), new(1, 1, 0, 1), new(1, 1, 1, 0),
        },
        // 2
        new Walls[] {
            new(1, 0, 1, 0), new(0, 1, 1, 0), new(1, 1, 0, 0), new(1, 1, 1, 0), new(0, 0, 1, 0),
            new(1, 0, 0, 0), new(1, 1, 1, 0), new(0, 1, 1, 0), new(1, 1, 0, 0), new(1, 0, 1, 0),
        },
        // 3
        new Walls[] {
            new(1, 0, 1, 0), new(0, 0, 1, 0), new(1, 0, 0, 0), new(1, 0, 1, 1), new(0, 0, 1, 0),
            new(1, 0, 0, 0), new(1, 0, 1, 1), new(0, 0, 1, 0), new(1, 0, 0, 0), new(1, 0, 1, 0),
        },
        // 4
        new Walls[] {
            new(1, 0, 1, 0), new(0, 0, 1, 1), new(0, 0, 0, 1), new(0, 1, 0, 1), new(0, 0, 0, 0),
            new(0, 0, 0, 0), new(0, 1, 0, 1), new(0, 0, 0, 1), new(1, 0, 0, 1), new(1, 0, 1, 0),
        },
        // 5
        new Walls[] {
            new(1, 0, 1, 0), new(0, 1, 0, 0), new(0, 1, 0, 1), new(1, 1, 0, 1), new(0, 0, 1, 0),
            new(1, 0, 0, 0), new(0, 1, 1, 1), new(0, 1, 0, 1), new(1, 1, 0, 1), new(1, 0, 1, 0),
        },
        // 6
        new Walls[] {
            new(1, 0, 1, 0), new(0, 1, 1, 0), new(0, 1, 0, 0), new(0, 1, 0, 1), new(0, 0, 0, 0),
            new(0, 0, 0, 0), new(0, 1, 0, 1), new(0, 1, 0, 0), new(1, 1, 0, 0), new(1, 0, 1, 0),
        },
        // 7
        new Walls[] {
            new(1, 0, 1, 0), new(0, 0, 1, 0), new(1, 0, 0, 0), new(1, 1, 1, 0), new(0, 0, 1, 0),
            new(1, 0, 0, 0), new(1, 1, 1, 0), new(0, 0, 1, 0), new(1, 0, 0, 0), new(1, 0, 1, 0),
        },
        // 8
        new Walls[] {
            new(1, 0, 1, 0), new(0, 0, 1, 1), new(1, 0, 0, 1), new(1, 0, 1, 1), new(0, 0, 1, 0),
            new(1, 0, 0, 0), new(1, 0, 1, 1), new(0, 0, 1, 1), new(1, 0, 0, 1), new(1, 0, 1, 0),
        },
        // 9
        new Walls[] {
            new(1, 0, 1, 0), new(0, 1, 1, 1), new(0, 1, 2, 1), new(0, 1, 0, 1), new(0, 0, 0, 1),
            new(0, 0, 0, 1), new(0, 1, 0, 1), new(0, 1, 0, 1), new(1, 1, 0, 1), new(1, 0, 1, 0),
        },
        // 10
        new Walls[] {
            new(0, 0, 1, 1), new(0, 1, 0, 1), new(0, 1, 0, 1), new(0, 1, 0, 1), new(0, 1, 0, 1),
            new(0, 1, 0, 1), new(0, 1, 0, 1), new(0, 1, 0, 1), new(0, 1, 0, 1), new(1, 0, 0, 1),
        },
    };

    private float encountRate;

    public Dungeon(float encountRate)
    {
        this.encountRate = encountRate;
    }

    public Walls[][] GetMap()
    {
        return map;
    }

    public void SetMap(Walls[][] map)
    {
        this.map = map;
    }

    public float GetEncountRate()
    {
        return encountRate;
    }

    public void SetEncountRate(float encountRate)
    {
        this.encountRate = encountRate;
    }
}