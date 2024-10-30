import "@typespec/http";
import "@typespec/rest";

@service({
    title: "KeyCredentialService",
  })
   
  @useAuth(ApiKeyAuth<ApiKeyLocation.header, "API-KEY">)
  namespace KeyCredentialService;
   
  using TypeSpec.Http;
  using TypeSpec.Rest;
     
  interface KeyCredentialServiceClient {
  }