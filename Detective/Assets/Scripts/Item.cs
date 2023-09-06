using UnityEngine;

[CreateAssetMenu]
public class Item : ScriptableObject
{
    public int id;
    public new string name; // �������� ��������
    public Sprite icon; // ������ ��������
    [TextArea(3, 10)]
    public string description; // �������� ��������
}