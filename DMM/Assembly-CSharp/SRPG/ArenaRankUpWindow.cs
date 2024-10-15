// Decompiled with JetBrains decompiler
// Type: SRPG.ArenaRankUpWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001FDC")]
  [AddComponentMenu("UI/ArenaRankUpWindow")]
  public class ArenaRankUpWindow : MonoBehaviour
  {
    [Token(Token = "0x4008715")]
    [FieldOffset(Offset = "0xC")]
    public Text OldRank;
    [Token(Token = "0x4008716")]
    [FieldOffset(Offset = "0x10")]
    public Text NewRank;
    [Token(Token = "0x4008717")]
    [FieldOffset(Offset = "0x14")]
    public Text DeltaRank;

    [Token(Token = "0x6008335")]
    [Address(RVA = "0x439A80", Offset = "0x438880", VA = "0x10439A80")]
    private void Start()
    {
    }

    [Token(Token = "0x6008336")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ArenaRankUpWindow()
    {
    }
  }
}
