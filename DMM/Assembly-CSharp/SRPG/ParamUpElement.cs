// Decompiled with JetBrains decompiler
// Type: SRPG.ParamUpElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20027C9")]
  [AddComponentMenu("UI/ParamUpElement")]
  public class ParamUpElement : MonoBehaviour
  {
    [Token(Token = "0x400BC81")]
    [FieldOffset(Offset = "0xC")]
    public Text param;
    [Token(Token = "0x400BC82")]
    [FieldOffset(Offset = "0x10")]
    public Text value;

    [Token(Token = "0x600B2D4")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ParamUpElement()
    {
    }
  }
}
