# ConnectorTools
Tools for building Connectors

# Command Structure:

## Notes:
- Problem: "connector new" vs "connector provision?"
  - "connector new" refers template creation
  - "connector provision new" refers to provisioning
- similar to dotnet without `--dry-run` full send

## Unanswered Questions:
- How do we want to traverse POCO models in order to generate JSON schema?
- Should we use manifests or conventions for structure? Maybe both?
- How do we handle generation/management of key resolvers and cache keys for Connector Builders?

* connector
  * --working-directory   (argument, default: current directory)
  * new 
    * --name              (argument, required)
    * --output            (argument, required)
    * --url-part          (argument, required)
    * --dry-run           (option)
  * provision
    * new
      * --name            (argument, required)
      * --output          (argument, required)
      * --url-part        (argument, required)
      * --description     (argument, required)
    * patch               (TBD)
  * client
    * new 
      * --type            (argument, required: [ oas, none ])
      * --auth            (argument, required: [ trimble-sso, oauth2-client-cred ])
      * --middleware      (argument, required: [ retry-policy, short-circuit ])
      * --pagination      (argument, [ total, has-more, read-until-empty ])
      * --filtering       (argument, [ header, request-body, query ])
      * --dry-run         (option?, TBD)
    * patch               (TBD)
  * data-object
    * new
      * --pagination      (argument, [ total, has-more, read-until-empty ])
      * --filtering       (argument, [ header, request-body, query ])
      * --schema?
      * --dry-run         (option?, TBD)
    * generate            (note: JSON schema?)
      * --file            (argument) 
    * patch               (TBD)
  * action
    * new
      * --schema?
      * --dry-run         (option?, TBD)
    * patch               (TBD)
      