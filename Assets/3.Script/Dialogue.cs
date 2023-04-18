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

        dialogTexts.Add(new DialogData("어서와 아까 전화한 알바 지원자 맞지?", "Alba"));
        dialogTexts.Add(new DialogData("/emote:Wonder/알바는 처음이라고? 괜찮아 우리 가게 일은 그렇게 어렵지 않으니까", "Alba"));
        dialogTexts.Add(new DialogData("/emote:Smile/면 익히고, 맛 선택하고 토핑 올리기만 하면 돼 어때 간단하지?", "Alba"));
        dialogTexts.Add(new DialogData("/emote:Smile/우선 면을 익혀줘, 손님은 적당히 익힌 면을 주문하셨네", "Alba"));
        dialogTexts.Add(new DialogData("/emote:Normal/냄비를 클릭하면 면을 삶을 수 있어.\n온도계의 표시가 초록색이 될 때 다시 냄비를 클릭해 줘.\n그럼 면을 건질 수 있어", "Alba"));
   
        DialogManager.Show(dialogTexts);        
    }

    public void NoodleSuccess()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("/emote:Smile/잘했어. 적당히 잘 삶아졌네", "Alba"));
        dialogTexts.Add(new DialogData("/emote:Smile/다음은 맛 선택이야. 손님은 매운 라멘을 주문하셨네", "Alba"));
        dialogTexts.Add(new DialogData("/emote:Normal/만들어둔 국물에 라유를 넣어주면 국물이 매콤해져\n한번 넣어볼래?", "Alba"));
        DialogManager.Show(dialogTexts);
    }

    public void NoodleFailure()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("/emote:Angry/손님이 원하는 느낌이 아닌 거 같은데.. 다시 한번 해볼래?", "Alba"));              

        DialogManager.Show(dialogTexts);
    }
   

    public void SoupSuccess()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("/emote:Smile/좋아 적당히 매콤해졌네 이제 토핑을 담아볼까?", "Alba"));
        dialogTexts.Add(new DialogData("/emote:Normal/토핑은 차슈, 계란, 어묵, 김이 있어", "Alba"));
        dialogTexts.Add(new DialogData("/emote:Normal/손님마다 원하는 토핑이 다 다르니까 잘 보고 넣어줘", "Alba"));
        dialogTexts.Add(new DialogData("/emote:Smile/원하는 토핑을 클릭 한 뒤 그릇으로 드래그 하면 토핑을 얹을 수 있어", "Alba"));
        DialogManager.Show(dialogTexts);
    }

    public void SoupFailure()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("/emote:Angry/배고파서 먹고 싶은 건 이해하지만, 다시 넣어줘", "Alba"));        
        DialogManager.Show(dialogTexts);        

    }   

    public void ToppingFailure()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("/emote:Wonder/빠진 토핑이 있는 거 같지 않아?", "Alba"));

        DialogManager.Show(dialogTexts);
    }

    public void ToppingSuccess()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("/emote:Smile/좋아, 손님이 원하는 토핑이 다 올라갔네\n그릇을 드래그해서 손님께 건네줘", "Alba"));

        DialogManager.Show(dialogTexts);
    }

    public void Final()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("/emote:Smile/다행이다 첫 날인데도 실력이 꽤 좋네", "Alba"));
        dialogTexts.Add(new DialogData("/emote:Normal/일단 주방은 됐고.. 다음은.. ", "Alba"));
        
        dialogTexts.Add(new DialogData("/sound:Phone//emote:Normal/음? 미안, 잠시만.. 여보세요?\n응.. 응.. 아 그래? 알겠어.", "Alba"));

        dialogTexts.Add(new DialogData("/emote:Wonder/지금 잠깐 요 앞에 좀 다녀와도 될까? 급한 일이라..", "Alba"));
        dialogTexts.Add(new DialogData("/emote:Smile/금방 갔다올거니까 너무 걱정하지마,\n그리고 어차피 지금 한가한 시간대니까", "Alba"));
        dialogTexts.Add(new DialogData("/emote:Smile/다녀올게! 잠깐 가게 좀 봐줘!", "Alba"));

        DialogManager.Show(dialogTexts);
        
    }


}
