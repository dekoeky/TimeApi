# $data = @(
#   [pscustomobject]@{
#     FirstName='Kevin';
#     LastName='Marquette';
#         }

#        [pscustomobject]@{FirstName='John'; LastName='Doe'}

#    )

# See https://learn.microsoft.com/en-us/dotnet/core/rid-catalog#known-rids


$configuration = 'Release'
$rids = @(
  'win-x64', 'win-x86', 'win-arm64',
  'linux-x64', 'linux-musl-x64', 'linux-musl-arm64', 'linux-arm', 'linux-arm64',
  #'linux-bionic-arm64',
  'osx-x64', 'osx-arm64'
)

# if(Test-Path ./TimeApi/bin){  rm -r ./TimeApi/bin }
# if(Test-Path ./TimeApi/obj){  rm -r ./TimeApi/obj }

foreach ($rid in $rids) 
{
  Write-Host "Processid RID '$rid'"

  dotnet publish TimeApi\TimeApi.csproj --self-contained -c $configuration -r $rid -o "./TimeApi/bin/$configuration/net8.0/publish/normal/$rid"
  dotnet publish TimeApi\TimeApi.csproj --self-contained -c $configuration -r $rid -o "./TimeApi/bin/$configuration/net8.0/publish/trimmed/$rid" /p:PublishTrimmed=true
}