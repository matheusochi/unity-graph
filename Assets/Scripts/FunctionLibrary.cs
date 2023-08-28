using UnityEngine;

public static class FunctionLibrary {
    public static float Wave (float xPosition, float time) {
        return Mathf.Sin(Mathf.PI * (xPosition + time));
    }
}