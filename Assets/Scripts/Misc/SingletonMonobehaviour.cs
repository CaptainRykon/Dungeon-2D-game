using UnityEngine;
public abstract class SingletonMonobehaviour<T> : MonoBehaviour where T: MonoBehaviour
{
    private static T instance;

    public static T Instance
    {
        get
        {
            return instance;
        }
    }

 
    #region Tooltip

    [Tooltip("Protected keyword mean it can be accessed inheriting classes  " +
        "virtual keyword basically allows the methods to be overriden by the inheritance classes")]

    #endregion Tooltip
    protected virtual void Awake()
    {
        if(instance == null)
        {
            instance = this as T;

        }
        else
        {
            Destroy(gameObject);
        }
    }
 
}
