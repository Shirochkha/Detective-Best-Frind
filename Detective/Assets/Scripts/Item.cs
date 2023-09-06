using UnityEngine;

[CreateAssetMenu]
public class Item : ScriptableObject
{
    public int id;
    public new string name; // Название предмета
    public Sprite icon; // Иконка предмета
    [TextArea(3, 10)]
    public string description; // Описание предмета
}