// Decompiled with JetBrains decompiler
// Type: SRPG.UnitCharacterQuestWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002BC3")]
  [FlowNode.Pin(10, "リスト切り替え", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(100, "クエストが選択された", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("UI/UnitCharacterQuestWindow")]
  public class UnitCharacterQuestWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400D6E8")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Transform QuestList;
    [Token(Token = "0x400D6E9")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    [StringIsResourcePath(typeof (GameObject))]
    private string StoryQuestItemTemplatePath;
    [Token(Token = "0x400D6EA")]
    [FieldOffset(Offset = "0x14")]
    [StringIsResourcePath(typeof (GameObject))]
    [SerializeField]
    private string StoryQuestDisableItemTemplatePath;
    [Token(Token = "0x400D6EB")]
    [FieldOffset(Offset = "0x18")]
    [StringIsResourcePath(typeof (GameObject))]
    [SerializeField]
    private string PieceQuestItemTemplatePath;
    [Token(Token = "0x400D6EC")]
    [FieldOffset(Offset = "0x1C")]
    [StringIsResourcePath(typeof (GameObject))]
    [SerializeField]
    private string QuestDetailTemplatePath;
    [Token(Token = "0x400D6ED")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject CharacterImage;
    [Token(Token = "0x400D6EE")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private string PieceQuestWorldId;
    [Token(Token = "0x400D6EF")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Image ListToggleButton;
    [Token(Token = "0x400D6F0")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Sprite StoryListSprite;
    [Token(Token = "0x400D6F1")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Sprite PieceListSprite;
    [Token(Token = "0x400D6F2")]
    [FieldOffset(Offset = "0x34")]
    private List<QuestParam> mQuestList;
    [Token(Token = "0x400D6F3")]
    [FieldOffset(Offset = "0x38")]
    private List<GameObject> mStoryQuestListItems;
    [Token(Token = "0x400D6F4")]
    [FieldOffset(Offset = "0x3C")]
    private List<GameObject> mPieceQuestListItems;
    [Token(Token = "0x400D6F5")]
    [FieldOffset(Offset = "0x40")]
    private bool mIsStoryList;
    [Token(Token = "0x400D6F6")]
    [FieldOffset(Offset = "0x41")]
    private bool mListRefreshing;
    [Token(Token = "0x400D6F7")]
    [FieldOffset(Offset = "0x44")]
    private GameObject mQuestDetail;
    [Token(Token = "0x400D6F8")]
    [FieldOffset(Offset = "0x48")]
    private UnitData mCurrentUnit;
    [Token(Token = "0x400D6F9")]
    [FieldOffset(Offset = "0x4C")]
    private bool mIsRestore;
    [Token(Token = "0x400D6FA")]
    [FieldOffset(Offset = "0x50")]
    private GameObject mStoryQuestItemPrefab;
    [Token(Token = "0x400D6FB")]
    [FieldOffset(Offset = "0x54")]
    private GameObject mStoryDisableQuestItemPrefab;
    [Token(Token = "0x400D6FC")]
    [FieldOffset(Offset = "0x58")]
    private GameObject mPieceQuestItemPrefab;
    [Token(Token = "0x400D6FD")]
    [FieldOffset(Offset = "0x5C")]
    private GameObject mQuestDetailPrefab;

    [Token(Token = "0x17001AA2")]
    public UnitData CurrentUnit
    {
      [Token(Token = "0x600C93B"), Address(RVA = "0x288000", Offset = "0x286E00", VA = "0x10288000")] get
      {
        return (UnitData) null;
      }
      [Token(Token = "0x600C93C"), Address(RVA = "0x288230", Offset = "0x287030", VA = "0x10288230")] set
      {
      }
    }

    [Token(Token = "0x17001AA3")]
    public bool IsRestore
    {
      [Token(Token = "0x600C93D"), Address(RVA = "0x288150", Offset = "0x286F50", VA = "0x10288150")] get
      {
        return new bool();
      }
      [Token(Token = "0x600C93E"), Address(RVA = "0x94BB10", Offset = "0x94A910", VA = "0x1094BB10")] set
      {
      }
    }

    [Token(Token = "0x17001AA4")]
    private GameObject StoryQuestItemPrefab
    {
      [Token(Token = "0x600C93F"), Address(RVA = "0x94BA70", Offset = "0x94A870", VA = "0x1094BA70")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x17001AA5")]
    private GameObject StoryDisableQuestItemPrefab
    {
      [Token(Token = "0x600C940"), Address(RVA = "0x94B9D0", Offset = "0x94A7D0", VA = "0x1094B9D0")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x17001AA6")]
    private GameObject PieceQuestItemPrefab
    {
      [Token(Token = "0x600C941"), Address(RVA = "0x94B890", Offset = "0x94A690", VA = "0x1094B890")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x17001AA7")]
    private GameObject QuestDetailPrefab
    {
      [Token(Token = "0x600C942"), Address(RVA = "0x94B930", Offset = "0x94A730", VA = "0x1094B930")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x600C943")]
    [Address(RVA = "0x94B580", Offset = "0x94A380", VA = "0x1094B580")]
    private void Start()
    {
    }

    [Token(Token = "0x600C944")]
    [Address(RVA = "0x94A920", Offset = "0x949720", VA = "0x1094A920")]
    private void CreateStoryList()
    {
    }

    [Token(Token = "0x600C945")]
    [Address(RVA = "0x94A510", Offset = "0x949310", VA = "0x1094A510")]
    private void CreatePieceQuest()
    {
    }

    [Token(Token = "0x600C946")]
    [Address(RVA = "0x94B340", Offset = "0x94A140", VA = "0x1094B340")]
    private void RefreshQuestList()
    {
    }

    [Token(Token = "0x600C947")]
    [Address(RVA = "0x94B0B0", Offset = "0x949EB0", VA = "0x1094B0B0")]
    private void OnQuestSelect(GameObject button)
    {
    }

    [Token(Token = "0x600C948")]
    [Address(RVA = "0x94AEA0", Offset = "0x949CA0", VA = "0x1094AEA0")]
    private void OnCloseItemDetail(GameObject go)
    {
    }

    [Token(Token = "0x600C949")]
    [Address(RVA = "0x94AF40", Offset = "0x949D40", VA = "0x1094AF40")]
    private void OnOpenItemDetail(GameObject go)
    {
    }

    [Token(Token = "0x600C94A")]
    [Address(RVA = "0x94B310", Offset = "0x94A110", VA = "0x1094B310")]
    private void OnToggleButton()
    {
    }

    [Token(Token = "0x600C94B")]
    [Address(RVA = "0x94B720", Offset = "0x94A520", VA = "0x1094B720")]
    private void UpdateToggleButton()
    {
    }

    [Token(Token = "0x600C94C")]
    [Address(RVA = "0x94A4D0", Offset = "0x9492D0", VA = "0x1094A4D0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C94D")]
    [Address(RVA = "0x94B7A0", Offset = "0x94A5A0", VA = "0x1094B7A0")]
    public UnitCharacterQuestWindow()
    {
    }
  }
}
