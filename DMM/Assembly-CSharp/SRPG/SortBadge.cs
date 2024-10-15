// Decompiled with JetBrains decompiler
// Type: SRPG.SortBadge
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002AC9")]
  [AddComponentMenu("UI/SortBadge")]
  public class SortBadge : MonoBehaviour
  {
    [Token(Token = "0x400D0AF")]
    [FieldOffset(Offset = "0xC")]
    [FourCC]
    public int ID;
    [Token(Token = "0x400D0B0")]
    [FieldOffset(Offset = "0x10")]
    public Image Icon;
    [Token(Token = "0x400D0B1")]
    [FieldOffset(Offset = "0x14")]
    public Text Value;
    [Token(Token = "0x400D0B2")]
    [FieldOffset(Offset = "0x18")]
    public Text Name;
    [Token(Token = "0x400D0B3")]
    [FieldOffset(Offset = "0x1C")]
    public Text ColotName;

    [Token(Token = "0x600C35E")]
    [Address(RVA = "0x8CD100", Offset = "0x8CBF00", VA = "0x108CD100")]
    public void SetValue(string value)
    {
    }

    [Token(Token = "0x600C35F")]
    [Address(RVA = "0x8CD180", Offset = "0x8CBF80", VA = "0x108CD180")]
    public void SetValue(int value)
    {
    }

    [Token(Token = "0x600C360")]
    [Address(RVA = "0x8CD080", Offset = "0x8CBE80", VA = "0x108CD080")]
    public void SetName(string name)
    {
    }

    [Token(Token = "0x600C361")]
    [Address(RVA = "0x8CD020", Offset = "0x8CBE20", VA = "0x108CD020")]
    public void SetColorName(string name)
    {
    }

    [Token(Token = "0x600C362")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public SortBadge()
    {
    }
  }
}
