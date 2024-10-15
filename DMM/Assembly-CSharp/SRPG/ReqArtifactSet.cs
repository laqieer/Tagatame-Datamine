// Decompiled with JetBrains decompiler
// Type: SRPG.ReqArtifactSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002E56")]
  public class ReqArtifactSet : WebAPI
  {
    [Token(Token = "0x600DA9A")]
    [Address(RVA = "0xA6C8D0", Offset = "0xA6B6D0", VA = "0x10A6C8D0")]
    public ReqArtifactSet(long iid_job, long iid_artifact, Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x600DA9B")]
    [Address(RVA = "0xA6CBE0", Offset = "0xA6B9E0", VA = "0x10A6CBE0")]
    public ReqArtifactSet(long iid_job, long[] iid_artifact, Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x600DA9C")]
    [Address(RVA = "0xA6CA10", Offset = "0xA6B810", VA = "0x10A6CA10")]
    public ReqArtifactSet(
      long iid_unit,
      long iid_job,
      long[] iid_artifact,
      Network.ResponseCallback response)
    {
    }
  }
}
