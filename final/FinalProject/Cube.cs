using System;

class Cube {
    private List<List<double>> points = new List<List<double>>();
    private int scale_factor = 5;

    double[,] matrix3dX = {
        {1,0,0,0}, // Last number is translation
        {0,Math.Cos(45 * (Math.PI/180)),-Math.Sin(45 * (Math.PI/180)),0}, // rotationX inside functions, degreesX = 45
        {0,Math.Sin(45 * (Math.PI/180)),Math.Cos(45 * (Math.PI/180)),150}, // rotationX inside functions, degreesX = 45
        {0,0,0,1}
    };

    double[,] matrix3dY = {
        {Math.Cos(45 * (Math.PI/180)),0,Math.Sin(45 * (Math.PI/180)),0}, // rotationY, degreesY = 45
        {0,1,0,0},
        {-Math.Sin(45 * (Math.PI/180)),0,Math.Cos(45 * (Math.PI/180)),0},
        {0,0,0,1}
    };

    double[,] matrix3dZ = {
        {Math.Cos(45 * (Math.PI/180)),-Math.Sin(45 * (Math.PI/180)),0,0}, // rotationY, degreesY = 45
        {Math.Sin(45 * (Math.PI/180)),Math.Cos(45 * (Math.PI/180)),0,0},
        {0,0,1,0},
        {0,0,0,1}
    };

    public List<double> ApplyMatrix3d(double x,double y,double z,double w,double[,] matrix) {
        double transformedx = (x * matrix[0,0]) + (y * matrix[0,1]) + (z * matrix[0,2]) + (w * matrix[0,3]);
        double transformedy = (x * matrix[1,0]) + (y * matrix[1,1]) + (z * matrix[1,2]) + (w * matrix[1,3]);
        double transformedz = (x * matrix[2,0]) + (y * matrix[2,1]) + (z * matrix[2,2]) + (w * matrix[2,3]);
        double transformedw = (x * matrix[3,0]) + (y * matrix[3,1]) + (z * matrix[3,2]) + (w * matrix[3,3]);
        return new List<double>{transformedx,transformedy,transformedz,transformedw};
    }

    public List<List<double>> GenerateCube() {
        for (int x = -12; x < 13; x++) {
            for (int y = -12; y < 13; y++) {
                for (int z = -12; z < 13; z++) {
                    if (x == -12 || x == 12 || y == -12 || y == 12 || z == -12 || z == 12) {
                        List<double> coords = new List<double>{x*scale_factor,y*scale_factor,z*scale_factor,1};
                        coords = ApplyMatrix3d(coords[0],coords[1],coords[2],coords[3],matrix3dZ);
                        coords = ApplyMatrix3d(coords[0],coords[1],coords[2],coords[3],matrix3dY);
                        coords = ApplyMatrix3d(coords[0],coords[1],coords[2],coords[3],matrix3dX);
                        points.Add(coords);
                    }
                }
            }
        }
        return points;
    }

    public void Draw() {
        points = GenerateCube();
        points.Sort((a, b) => a[2].CompareTo(b[2]));
        foreach (var point in points) {
            Console.WriteLine(point[2]);
        }
    }
}