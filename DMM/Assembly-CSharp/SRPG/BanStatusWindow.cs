// Decompiled with JetBrains decompiler
// Type: SRPG.BanStatusWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200207E")]
  [AddComponentMenu("UI/BanStatusWindow")]
  public class BanStatusWindow : MonoBehaviour
  {
    [Token(Token = "0x4008BFF")]
    [FieldOffset(Offset = "0xC")]
    public Text Title;
    [Token(Token = "0x4008C00")]
    [FieldOffset(Offset = "0x10")]
    public Text LimitDate;
    [Token(Token = "0x4008C01")]
    [FieldOffset(Offset = "0x14")]
    public Text Message;
    [Token(Token = "0x4008C02")]
    [FieldOffset(Offset = "0x18")]
    public Text CustomerID;

    [Token(Token = "0x6008737")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Awake()
    {
    }

    [Token(Token = "0x6008738")]
    [Address(RVA = "0x487EE0", Offset = "0x486CE0", VA = "0x10487EE0")]
    private void Start()
    {
    }

    [Token(Token = "0x6008739")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public BanStatusWindow()
    {
    }
  }
}
