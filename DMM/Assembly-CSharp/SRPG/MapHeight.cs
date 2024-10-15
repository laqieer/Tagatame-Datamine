// Decompiled with JetBrains decompiler
// Type: SRPG.MapHeight
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C7C")]
  [AddComponentMenu("Battle/MapHeight")]
  public class MapHeight : MonoBehaviour
  {
    [Token(Token = "0x40021E1")]
    [FieldOffset(Offset = "0xC")]
    private int oldHeight;
    [Token(Token = "0x40021E2")]
    [FieldOffset(Offset = "0x10")]
    public int Height;
    [Token(Token = "0x40021E3")]
    [FieldOffset(Offset = "0x14")]
    public BitmapText MapHeightText;
    [Token(Token = "0x40021E4")]
    [FieldOffset(Offset = "0x18")]
    private Unit mFocusUnit;

    [Token(Token = "0x170002F5")]
    public Unit FocusUnit
    {
      [Token(Token = "0x6003136"), Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")] set
      {
      }
    }

    [Token(Token = "0x6003137")]
    [Address(RVA = "0x10231B0", Offset = "0x1021FB0", VA = "0x110231B0")]
    private void Start()
    {
    }

    [Token(Token = "0x6003138")]
    [Address(RVA = "0x10231F0", Offset = "0x1021FF0", VA = "0x110231F0")]
    private void Update()
    {
    }

    [Token(Token = "0x6003139")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public MapHeight()
    {
    }
  }
}
