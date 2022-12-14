using UnityEngine;

public class CustomVector4 {
     public float x;
     public float y;
     public float z;
     public float w;

     public static readonly CustomVector4 zero = new CustomVector4(0, 0, 0, 0);
     public static readonly CustomVector4 one = new CustomVector4(1, 1, 1, 1);

     public CustomVector4() {
     }

     public CustomVector4(Vector3 v, float w) : this(v.x, v.y, v.z, w) {
     }

     public CustomVector4(float x, float y, float z, float w) {
          this.x = x;
          this.y = y;
          this.z = z;
          this.w = w;
     }

     public static float Dot(CustomVector4 a, CustomVector4 b) {
          return a.x * b.x + a.y * b.y + a.z * b.z + a.w * b.w;
     }

     public string ToMatrixString() {
          return $"{x:F5}\t{y:F5}\t{z:F5}\t{w:F5}";
     }

     public override string ToString() {
          return $"({x:F1}, {y:F1}, {z:F1}, {w:F1})";
     }
}