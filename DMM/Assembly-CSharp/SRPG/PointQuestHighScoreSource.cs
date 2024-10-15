// Decompiled with JetBrains decompiler
// Type: SRPG.PointQuestHighScoreSource
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200284F")]
  public class PointQuestHighScoreSource : MonoBehaviour
  {
    [Token(Token = "0x400C068")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private LayoutElement mLayoutElement;
    [Token(Token = "0x400C069")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private float mFixMinHeight;
    [Token(Token = "0x400C06A")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private float mFixAnchorSize;
    [Token(Token = "0x400C06B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mHighScoreItem;
    [Token(Token = "0x400C06C")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject mQuestMask;
    [Token(Token = "0x400C06D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mQuestDetailBtn;
    [Token(Token = "0x400C06E")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Text mHighScoreNum;
    [Token(Token = "0x400C06F")]
    [FieldOffset(Offset = "0x28")]
    private bool mIsPointQuest;
    [Token(Token = "0x400C070")]
    [FieldOffset(Offset = "0x2C")]
    private string mQuestIname;

    [Token(Token = "0x170018EB")]
    public GameObject HighScoreItemObject
    {
      [Token(Token = "0x600B5EF"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x170018EC")]
    public Text HighScoreNum
    {
      [Token(Token = "0x600B5F0"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (Text) null;
      }
    }

    [Token(Token = "0x170018ED")]
    public string QuestIname
    {
      [Token(Token = "0x600B5F1"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600B5F2"), Address(RVA = "0x27FBD0", Offset = "0x27E9D0", VA = "0x1027FBD0")] set
      {
      }
    }

    [Token(Token = "0x170018EE")]
    public bool IsPointQuest
    {
      [Token(Token = "0x600B5F3"), Address(RVA = "0x34F470", Offset = "0x34E270", VA = "0x1034F470")] get
      {
        return new bool();
      }
      [Token(Token = "0x600B5F4"), Address(RVA = "0x7BB1C0", Offset = "0x7B9FC0", VA = "0x107BB1C0")] set
      {
      }
    }

    [Token(Token = "0x170018EF")]
    public float PointQuestAdjustedHeight
    {
      [Token(Token = "0x600B5F5"), Address(RVA = "0x2CD710", Offset = "0x2CC510", VA = "0x102CD710")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x170018F0")]
    public GameObject QuestMask
    {
      [Token(Token = "0x600B5F6"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x170018F1")]
    public GameObject QuestDetailBtn
    {
      [Token(Token = "0x600B5F7"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x600B5F8")]
    [Address(RVA = "0x7BAF50", Offset = "0x7B9D50", VA = "0x107BAF50")]
    private void Start()
    {
    }

    [Token(Token = "0x600B5F9")]
    [Address(RVA = "0x7BAE90", Offset = "0x7B9C90", VA = "0x107BAE90")]
    public void SelectedMissionBtn()
    {
    }

    [Token(Token = "0x600B5FA")]
    [Address(RVA = "0x7BB160", Offset = "0x7B9F60", VA = "0x107BB160")]
    public PointQuestHighScoreSource()
    {
    }
  }
}
