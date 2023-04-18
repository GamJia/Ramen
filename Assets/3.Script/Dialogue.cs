using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{    
    public DialogManager DialogManager;
    [SerializeField] private Temperature temperature;
    [SerializeField] ToppingDragDrop toppingdragdrop;

    [SerializeField] GameObject water;
    [SerializeField] GameObject net;

    public bool inActive = false;

    public bool Active()
    {
        return DialogManager.gameObject.activeSelf;
    }

   
    private void Awake()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("��� �Ʊ� ��ȭ�� �˹� ������ ����?", "Alba"));
        dialogTexts.Add(new DialogData("/emote:Wonder/�˹ٴ� ó���̶��? ������ �츮 ���� ���� �׷��� ����� �����ϱ�", "Alba"));
        dialogTexts.Add(new DialogData("/emote:Smile/�� ������, �� �����ϰ� ���� �ø��⸸ �ϸ� �� � ��������?", "Alba"));
        dialogTexts.Add(new DialogData("/emote:Smile/�켱 ���� ������, �մ��� ������ ���� ���� �ֹ��ϼ̳�", "Alba"));
        dialogTexts.Add(new DialogData("/emote:Normal/���� Ŭ���ϸ� ���� ���� �� �־�.\n�µ����� ǥ�ð� �ʷϻ��� �� �� �ٽ� ���� Ŭ���� ��.\n�׷� ���� ���� �� �־�", "Alba"));
   
        DialogManager.Show(dialogTexts);        
    }

    public void NoodleSuccess()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("/emote:Smile/���߾�. ������ �� �������", "Alba"));
        dialogTexts.Add(new DialogData("/emote:Smile/������ �� �����̾�. �մ��� �ſ� ����� �ֹ��ϼ̳�", "Alba"));
        dialogTexts.Add(new DialogData("/emote:Normal/������ ������ ������ �־��ָ� ������ ��������\n�ѹ� �־��?", "Alba"));
        DialogManager.Show(dialogTexts);
    }

    public void NoodleFailure()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("/emote:Angry/�մ��� ���ϴ� ������ �ƴ� �� ������.. �ٽ� �ѹ� �غ���?", "Alba"));              

        DialogManager.Show(dialogTexts);
    }
   

    public void SoupSuccess()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("/emote:Smile/���� ������ ���������� ���� ������ ��ƺ���?", "Alba"));
        dialogTexts.Add(new DialogData("/emote:Normal/������ ����, ���, �, ���� �־�", "Alba"));
        dialogTexts.Add(new DialogData("/emote:Normal/�մԸ��� ���ϴ� ������ �� �ٸ��ϱ� �� ���� �־���", "Alba"));
        dialogTexts.Add(new DialogData("/emote:Smile/���ϴ� ������ Ŭ�� �� �� �׸����� �巡�� �ϸ� ������ ���� �� �־�", "Alba"));
        DialogManager.Show(dialogTexts);
    }

    public void SoupFailure()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("/emote:Angry/����ļ� �԰� ���� �� ����������, �ٽ� �־���", "Alba"));        
        DialogManager.Show(dialogTexts);        

    }   

    public void ToppingFailure()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("/emote:Wonder/���� ������ �ִ� �� ���� �ʾ�?", "Alba"));

        DialogManager.Show(dialogTexts);
    }

    public void ToppingSuccess()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("/emote:Smile/����, �մ��� ���ϴ� ������ �� �ö󰬳�\n�׸��� �巡���ؼ� �մԲ� �ǳ���", "Alba"));

        DialogManager.Show(dialogTexts);
    }

    public void Final()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("/emote:Smile/�����̴� ù ���ε��� �Ƿ��� �� ����", "Alba"));
        dialogTexts.Add(new DialogData("/emote:Normal/�ϴ� �ֹ��� �ư�.. ������.. ", "Alba"));
        
        dialogTexts.Add(new DialogData("/sound:Phone//emote:Normal/��? �̾�, ��ø�.. ��������?\n��.. ��.. �� �׷�? �˰ھ�.", "Alba"));

        dialogTexts.Add(new DialogData("/emote:Wonder/���� ��� �� �տ� �� �ٳ�͵� �ɱ�? ���� ���̶�..", "Alba"));
        dialogTexts.Add(new DialogData("/emote:Smile/�ݹ� ���ٿðŴϱ� �ʹ� ����������,\n�׸��� ������ ���� �Ѱ��� �ð���ϱ�", "Alba"));
        dialogTexts.Add(new DialogData("/emote:Smile/�ٳ�ð�! ��� ���� �� ����!", "Alba"));

        DialogManager.Show(dialogTexts);
        
    }


}
