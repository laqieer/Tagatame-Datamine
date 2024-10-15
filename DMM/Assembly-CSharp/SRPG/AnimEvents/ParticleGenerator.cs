// Decompiled with JetBrains decompiler
// Type: SRPG.AnimEvents.ParticleGenerator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG.AnimEvents
{
  [Token(Token = "0x20032E0")]
  public class ParticleGenerator : AnimEventWithTarget
  {
    [Token(Token = "0x400EF83")]
    [FieldOffset(Offset = "0x38")]
    public GameObject Template;
    [Token(Token = "0x400EF84")]
    [FieldOffset(Offset = "0x3C")]
    public bool Attach;
    [Token(Token = "0x400EF85")]
    [FieldOffset(Offset = "0x3D")]
    public bool NotParticle;
    [Token(Token = "0x400EF86")]
    [FieldOffset(Offset = "0x3E")]
    public bool Preload;
    [Token(Token = "0x400EF87")]
    [FieldOffset(Offset = "0x40")]
    private GameObject generateObject;

    [Token(Token = "0x600DF8C")]
    [Address(RVA = "0xA92510", Offset = "0xA91310", VA = "0x10A92510")]
    public void PreLoad(GameObject go)
    {
    }

    [Token(Token = "0x600DF8D")]
    [Address(RVA = "0xA92000", Offset = "0xA90E00", VA = "0x10A92000")]
    private void Generate(GameObject go)
    {
    }

    [Token(Token = "0x600DF8E")]
    [Address(RVA = "0xA92250", Offset = "0xA91050", VA = "0x10A92250", Slot = "4")]
    public override void OnStart(GameObject go)
    {
    }

    [Token(Token = "0x600DF8F")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "7")]
    protected virtual void OnGenerate(GameObject go)
    {
    }

    [Token(Token = "0x600DF90")]
    [Address(RVA = "0xA8FDB0", Offset = "0xA8EBB0", VA = "0x10A8FDB0")]
    public ParticleGenerator()
    {
    }
  }
}
