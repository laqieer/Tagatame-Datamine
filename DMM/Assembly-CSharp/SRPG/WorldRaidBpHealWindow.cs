// Decompiled with JetBrains decompiler
// Type: SRPG.WorldRaidBpHealWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D51")]
  public class WorldRaidBpHealWindow : MonoBehaviour
  {
    [Token(Token = "0x400E20F")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Transform ParentObj;
    [Token(Token = "0x400E210")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private WorldRaidBpHealItem ListItem;

    [Token(Token = "0x600D335")]
    [Address(RVA = "0x9E59D0", Offset = "0x9E47D0", VA = "0x109E59D0")]
    private void Start()
    {
    }

    [Token(Token = "0x600D336")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public WorldRaidBpHealWindow()
    {
    }
  }
}
