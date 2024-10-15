// Decompiled with JetBrains decompiler
// Type: SRPG.StatusListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B05")]
  [AddComponentMenu("UI/StatusListItem")]
  public class StatusListItem : MonoBehaviour
  {
    [Token(Token = "0x400D1EC")]
    [FieldOffset(Offset = "0xC")]
    public Text Label;
    [Token(Token = "0x400D1ED")]
    [FieldOffset(Offset = "0x10")]
    public Text Value;
    [Token(Token = "0x400D1EE")]
    [FieldOffset(Offset = "0x14")]
    public Text Bonus;
    [Token(Token = "0x400D1EF")]
    [FieldOffset(Offset = "0x18")]
    public ParamTypes Type;
    [Token(Token = "0x400D1F0")]
    [FieldOffset(Offset = "0x1C")]
    public string Tag;
    [Token(Token = "0x400D1F1")]
    [FieldOffset(Offset = "0x20")]
    public bool IsMultiply;

    [Token(Token = "0x600C4EA")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public StatusListItem()
    {
    }
  }
}
