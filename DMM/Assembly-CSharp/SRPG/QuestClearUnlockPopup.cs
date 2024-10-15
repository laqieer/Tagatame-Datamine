// Decompiled with JetBrains decompiler
// Type: SRPG.QuestClearUnlockPopup
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
  [Token(Token = "0x2002893")]
  [AddComponentMenu("UI/QuestClearUnlockPopup")]
  public class QuestClearUnlockPopup : MonoBehaviour
  {
    [Token(Token = "0x400C21C")]
    [FieldOffset(Offset = "0xC")]
    public Button CloseButton;
    [Token(Token = "0x400C21D")]
    [FieldOffset(Offset = "0x10")]
    public GameObject ItemWindow;
    [Token(Token = "0x400C21E")]
    [FieldOffset(Offset = "0x14")]
    public string ItemCloseFlag;
    [Token(Token = "0x400C21F")]
    [FieldOffset(Offset = "0x18")]
    public string ItemEndAnimation;
    [Token(Token = "0x400C220")]
    [FieldOffset(Offset = "0x1C")]
    public string ItemOpendAnimation;
    [Token(Token = "0x400C221")]
    [FieldOffset(Offset = "0x20")]
    public GameObject SkillNewItem;
    [Token(Token = "0x400C222")]
    [FieldOffset(Offset = "0x24")]
    public GameObject SkillUpdateItem;
    [Token(Token = "0x400C223")]
    [FieldOffset(Offset = "0x28")]
    public GameObject AbilityNewItem;
    [Token(Token = "0x400C224")]
    [FieldOffset(Offset = "0x2C")]
    public GameObject AbilityUpdateItem;
    [Token(Token = "0x400C225")]
    [FieldOffset(Offset = "0x30")]
    public GameObject LeaderSkillNewItem;
    [Token(Token = "0x400C226")]
    [FieldOffset(Offset = "0x34")]
    public GameObject LeaderSkillUpdateItem;
    [Token(Token = "0x400C227")]
    [FieldOffset(Offset = "0x38")]
    public GameObject MasterAbilityNewItem;
    [Token(Token = "0x400C228")]
    [FieldOffset(Offset = "0x3C")]
    public GameObject MasterAbilityUpdateItem;
    [Token(Token = "0x400C229")]
    [FieldOffset(Offset = "0x40")]
    private QuestClearUnlockUnitDataParam[] mUnlocks;
    [Token(Token = "0x400C22A")]
    [FieldOffset(Offset = "0x44")]
    private List<GameObject> mListItems;
    [Token(Token = "0x400C22B")]
    [FieldOffset(Offset = "0x48")]
    private UnitData mUnit;
    [Token(Token = "0x400C22C")]
    [FieldOffset(Offset = "0x4C")]
    private Animator mWindowAnimator;
    [Token(Token = "0x400C22D")]
    [FieldOffset(Offset = "0x50")]
    private bool mInitalize;

    [Token(Token = "0x600B765")]
    [Address(RVA = "0x7DFFB0", Offset = "0x7DEDB0", VA = "0x107DFFB0")]
    private void Start()
    {
    }

    [Token(Token = "0x600B766")]
    [Address(RVA = "0x7E06F0", Offset = "0x7DF4F0", VA = "0x107E06F0")]
    private void Update()
    {
    }

    [Token(Token = "0x600B767")]
    [Address(RVA = "0x7DFF20", Offset = "0x7DED20", VA = "0x107DFF20")]
    public void OnClick()
    {
    }

    [Token(Token = "0x600B768")]
    [Address(RVA = "0x7DFEA0", Offset = "0x7DECA0", VA = "0x107DFEA0")]
    private GameObject CreateInstance(GameObject template) => (GameObject) null;

    [Token(Token = "0x600B769")]
    [Address(RVA = "0x7E0980", Offset = "0x7DF780", VA = "0x107E0980")]
    public QuestClearUnlockPopup()
    {
    }
  }
}
