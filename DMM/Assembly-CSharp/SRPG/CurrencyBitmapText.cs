// Decompiled with JetBrains decompiler
// Type: SRPG.CurrencyBitmapText
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20022EF")]
  public class CurrencyBitmapText : BitmapText, ISerializationCallbackReceiver
  {
    [Token(Token = "0x4009BB5")]
    private const string mDelimiter = ",";
    [Token(Token = "0x4009BB6")]
    private const int mGroupingCount = 3;
    [Token(Token = "0x4009BB7")]
    [FieldOffset(Offset = "0xAC")]
    private string mModifiedText;
    [Token(Token = "0x4009BB8")]
    [FieldOffset(Offset = "0xB0")]
    private readonly UIVertex[] m_TempVerts;

    [Token(Token = "0x6009623")]
    [Address(RVA = "0x58EAA0", Offset = "0x58D8A0", VA = "0x1058EAA0")]
    public static string CreateFormatedText(string str) => (string) null;

    [Token(Token = "0x6009624")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "85")]
    public void OnBeforeSerialize()
    {
    }

    [Token(Token = "0x6009625")]
    [Address(RVA = "0x58ED50", Offset = "0x58DB50", VA = "0x1058ED50", Slot = "86")]
    public void OnAfterDeserialize()
    {
    }

    [Token(Token = "0x170014F4")]
    public override string text
    {
      [Token(Token = "0x6009626"), Address(RVA = "0x4F6600", Offset = "0x4F5400", VA = "0x104F6600", Slot = "74")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009627"), Address(RVA = "0x58F640", Offset = "0x58E440", VA = "0x1058F640", Slot = "75")] set
      {
      }
    }

    [Token(Token = "0x170014F5")]
    public string modifiedText
    {
      [Token(Token = "0x6009628"), Address(RVA = "0x349120", Offset = "0x347F20", VA = "0x10349120")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009629"), Address(RVA = "0x58F610", Offset = "0x58E410", VA = "0x1058F610")] set
      {
      }
    }

    [Token(Token = "0x600962A")]
    [Address(RVA = "0x58ED80", Offset = "0x58DB80", VA = "0x1058ED80", Slot = "44")]
    protected override void OnPopulateMesh(VertexHelper toFill)
    {
    }

    [Token(Token = "0x170014F6")]
    public override float preferredWidth
    {
      [Token(Token = "0x600962B"), Address(RVA = "0x58F510", Offset = "0x58E310", VA = "0x1058F510", Slot = "79")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x170014F7")]
    public override float preferredHeight
    {
      [Token(Token = "0x600962C"), Address(RVA = "0x58F410", Offset = "0x58E210", VA = "0x1058F410", Slot = "82")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x600962D")]
    [Address(RVA = "0x58F3C0", Offset = "0x58E1C0", VA = "0x1058F3C0")]
    public CurrencyBitmapText()
    {
    }
  }
}
