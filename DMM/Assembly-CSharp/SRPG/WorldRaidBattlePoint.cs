// Decompiled with JetBrains decompiler
// Type: SRPG.WorldRaidBattlePoint
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D3C")]
  public class WorldRaidBattlePoint : MonoBehaviour
  {
    [Token(Token = "0x400E184")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList ExhibitList;
    [Token(Token = "0x400E185")]
    [FieldOffset(Offset = "0x10")]
    private WorldRaidBattlePointModel mModel;

    [Token(Token = "0x600D2D6")]
    [Address(RVA = "0x9E18E0", Offset = "0x9E06E0", VA = "0x109E18E0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600D2D7")]
    [Address(RVA = "0x9E1A00", Offset = "0x9E0800", VA = "0x109E1A00")]
    public void SetUp()
    {
    }

    [Token(Token = "0x600D2D8")]
    [Address(RVA = "0x9E19D0", Offset = "0x9E07D0", VA = "0x109E19D0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600D2D9")]
    [Address(RVA = "0x9E1950", Offset = "0x9E0750", VA = "0x109E1950")]
    private void Draw()
    {
    }

    [Token(Token = "0x600D2DA")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public WorldRaidBattlePoint()
    {
    }
  }
}
