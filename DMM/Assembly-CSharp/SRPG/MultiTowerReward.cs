// Decompiled with JetBrains decompiler
// Type: SRPG.MultiTowerReward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20027AC")]
  [AddComponentMenu("UI/MultiTowerReward")]
  public class MultiTowerReward : MonoBehaviour
  {
    [Token(Token = "0x400BB90")]
    [FieldOffset(Offset = "0xC")]
    private readonly float WAIT_TIME;
    [Token(Token = "0x400BB91")]
    [FieldOffset(Offset = "0x10")]
    private readonly float WAIT_OPEN;
    [Token(Token = "0x400BB92")]
    [FieldOffset(Offset = "0x14")]
    public GameObject item;
    [Token(Token = "0x400BB93")]
    [FieldOffset(Offset = "0x18")]
    public GameObject root;
    [Token(Token = "0x400BB94")]
    [FieldOffset(Offset = "0x1C")]
    public GameObject template;
    [Token(Token = "0x400BB95")]
    [FieldOffset(Offset = "0x20")]
    public GameObject parent;
    [Token(Token = "0x400BB96")]
    [FieldOffset(Offset = "0x24")]
    public GameObject arrival;
    [Token(Token = "0x400BB97")]
    [FieldOffset(Offset = "0x28")]
    public Text floorTxt;
    [Token(Token = "0x400BB98")]
    [FieldOffset(Offset = "0x2C")]
    public Text floorEffTxt;
    [Token(Token = "0x400BB99")]
    [FieldOffset(Offset = "0x30")]
    public Text rewardTxt;
    [Token(Token = "0x400BB9A")]
    [FieldOffset(Offset = "0x34")]
    public Text okTxt;
    [Token(Token = "0x400BB9B")]
    [FieldOffset(Offset = "0x38")]
    public Text getTxt;
    [Token(Token = "0x400BB9C")]
    [FieldOffset(Offset = "0x3C")]
    public string openAnim;
    [Token(Token = "0x400BB9D")]
    [FieldOffset(Offset = "0x40")]
    public string nextAnim;
    [Token(Token = "0x400BB9E")]
    [FieldOffset(Offset = "0x44")]
    public string resultAnim;
    [Token(Token = "0x400BB9F")]
    [FieldOffset(Offset = "0x48")]
    private int mNow;
    [Token(Token = "0x400BBA0")]
    [FieldOffset(Offset = "0x4C")]
    private int mMax;
    [Token(Token = "0x400BBA1")]
    [FieldOffset(Offset = "0x50")]
    private float mWaitTime;
    [Token(Token = "0x400BBA2")]
    [FieldOffset(Offset = "0x54")]
    private MultiTowerReward.MODE mMode;
    [Token(Token = "0x400BBA3")]
    [FieldOffset(Offset = "0x58")]
    private int mRound;

    [Token(Token = "0x600B226")]
    [Address(RVA = "0x7687E0", Offset = "0x7675E0", VA = "0x107687E0")]
    private void Start()
    {
    }

    [Token(Token = "0x600B227")]
    [Address(RVA = "0x767F10", Offset = "0x766D10", VA = "0x10767F10")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600B228")]
    [Address(RVA = "0x7680D0", Offset = "0x766ED0", VA = "0x107680D0")]
    private void SetButtonText(bool bNext)
    {
    }

    [Token(Token = "0x600B229")]
    [Address(RVA = "0x768970", Offset = "0x767770", VA = "0x10768970")]
    private void Update()
    {
    }

    [Token(Token = "0x600B22A")]
    [Address(RVA = "0x768220", Offset = "0x767020", VA = "0x10768220")]
    private bool SetData(int idx, bool bPlay = false, GameObject obj = null) => new bool();

    [Token(Token = "0x600B22B")]
    [Address(RVA = "0x768450", Offset = "0x767250", VA = "0x10768450")]
    private void SetRewardName(int idx, MultiTowerFloorParam param)
    {
    }

    [Token(Token = "0x600B22C")]
    [Address(RVA = "0x768020", Offset = "0x766E20", VA = "0x10768020")]
    private void ReqAnim(string anim)
    {
    }

    [Token(Token = "0x600B22D")]
    [Address(RVA = "0x767BC0", Offset = "0x7669C0", VA = "0x10767BC0")]
    private void CreateResult()
    {
    }

    [Token(Token = "0x600B22E")]
    [Address(RVA = "0x767DF0", Offset = "0x766BF0", VA = "0x10767DF0")]
    public void OnClickNext()
    {
    }

    [Token(Token = "0x600B22F")]
    [Address(RVA = "0x768A60", Offset = "0x767860", VA = "0x10768A60")]
    public MultiTowerReward()
    {
    }

    [Token(Token = "0x20027AD")]
    private enum MODE
    {
      [Token(Token = "0x400BBA5")] NONE,
      [Token(Token = "0x400BBA6")] REQ,
      [Token(Token = "0x400BBA7")] COUNTDOWN,
      [Token(Token = "0x400BBA8")] WAIT,
      [Token(Token = "0x400BBA9")] NEXT,
      [Token(Token = "0x400BBAA")] FINISH,
      [Token(Token = "0x400BBAB")] END,
    }
  }
}
