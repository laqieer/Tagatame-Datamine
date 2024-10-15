// Decompiled with JetBrains decompiler
// Type: SRPG.AdventureBookItemArea
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F72")]
  [AddComponentMenu("UI/Adventure/AdventureBookItemArea")]
  public class AdventureBookItemArea : MonoBehaviour
  {
    [Token(Token = "0x40084BF")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text TextAreaName;
    [Token(Token = "0x40084C0")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    [Space(5f)]
    private LText TextAreaLevelPrefix;
    [Token(Token = "0x40084C1")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private BitmapText TextAreaLevelNum;
    [Token(Token = "0x40084C2")]
    [FieldOffset(Offset = "0x18")]
    [Space(5f)]
    [SerializeField]
    private GameObject GoCurrent;
    [Token(Token = "0x40084C3")]
    [FieldOffset(Offset = "0x1C")]
    [Space(5f)]
    [SerializeField]
    private SRPG_Button ButtonSelect;
    [Token(Token = "0x40084C4")]
    [FieldOffset(Offset = "0x20")]
    private AdventureBookWindow mParent;
    [Token(Token = "0x40084C5")]
    [FieldOffset(Offset = "0x24")]
    private int mIndex;
    [Token(Token = "0x40084C6")]
    [FieldOffset(Offset = "0x28")]
    private AdventureBook mBookData;

    [Token(Token = "0x17001285")]
    public AdventureBookWindow Parent
    {
      [Token(Token = "0x600812F"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (AdventureBookWindow) null;
      }
    }

    [Token(Token = "0x17001286")]
    public int Index
    {
      [Token(Token = "0x6008130"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001287")]
    public AdventureBook BookData
    {
      [Token(Token = "0x6008131"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (AdventureBook) null;
      }
    }

    [Token(Token = "0x6008132")]
    [Address(RVA = "0x41B420", Offset = "0x41A220", VA = "0x1041B420")]
    public void Setup(
      AdventureBookWindow parent,
      int index,
      AdventureBook book_data,
      UnityAction action)
    {
    }

    [Token(Token = "0x6008133")]
    [Address(RVA = "0x41B3D0", Offset = "0x41A1D0", VA = "0x1041B3D0")]
    public void SetCurrent(bool is_current)
    {
    }

    [Token(Token = "0x6008134")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public AdventureBookItemArea()
    {
    }
  }
}
