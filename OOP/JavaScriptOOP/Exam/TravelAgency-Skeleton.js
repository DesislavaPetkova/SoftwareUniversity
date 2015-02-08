function processTravelAgencyCommands(commands) {
    'use strict';

    Object.prototype.extends = function (parent) {
        this.prototype = Object.create(parent.prototype);
        this.prototype.constructor = this;
    }

    Object.prototype.validateNonEmptyString = function (value, variableName) {
        if (typeof (value) != 'string' || !value) {
            throw new Error(variableName + " should be nonempty string");
        };      
    }

    Object.prototype.validateIntegerRange = function(value, variableName, min, max) {
        if(!value === parseInt(value, 10)){
            throw new Error(variableName +"number should be Integer");
        };
        if ((typeof value != 'number') || (value < min || value > max)) {
            throw new Error(variableName +' number should be number in right range');
        };
    }

    Object.prototype.validateBoolean = function(value, variableName) {
        if (typeof value != 'boolean') {
            throw new Error (variableName+' should be a boolean');
        };
    }

    Object.prototype.validateNonEmptyObject = function(value, className, variableName){
        if (! (value instanceof className) || !value) {
            throw new Error(variableName + " should be non empty object " + className.prototype.constructor.name);
        };
    }

    Object.prototype.parseDate = function (dateStr) {
        if (!dateStr) {
            return undefined;
        }
        var date = new Date(Date.parse(dateStr.replace(/-/g, ' ')));
        var dateFormatted = formatDate(date);
        if (dateStr != dateFormatted) {
            throw new Error("Invalid date: " + dateStr);
        }
        return date;
    }
    
    Object.prototype.formatDate = function (date) {
        var day = date.getDate();
        var monthName = date.toString().split(' ')[1];
        var year = date.getFullYear();
        return day + '-' + monthName + '-' + year;
    }   



    var Models = (function() {
        var Destination = (function() {
            function Destination(location, landmark) {
                this.setLocation(location);
                this.setLandmark(landmark);
            }

            Destination.prototype.getLocation = function() {
                return this._location;
            }

            Destination.prototype.setLocation = function(location) {
                if (location === undefined || location === "") {
                    throw new Error("Location cannot be empty or undefined.");
                }
                this._location = location;
            }

            Destination.prototype.getLandmark = function() {
                return this._landmark;
            }

            Destination.prototype.setLandmark = function(landmark) {
                if (landmark === undefined || landmark == "") {
                    throw new Error("Landmark cannot be empty or undefined.");
                }
                this._landmark = landmark;
            }

            Destination.prototype.toString = function() {
                return this.constructor.name + ": " +
                    "location=" + this.getLocation() +
                    ",landmark=" + this.getLandmark();
            }

            return Destination;
        }());        

        var Travel = (function() {
        'use strict';    
            function Travel(name, startDate, endDate, price) {            
                if (!(this instanceof Travel)) {
                    return new Travel(args);
                }
                if (this.constructor === Travel) {
                    throw new Error("Can't instantiate abstract class!");       
                }
                this.setName(name);
                this.setStartDate(startDate);
                this.setEndDate(endDate);
                this.setPrice(price);
                

            }
            Travel.prototype.getName = function() {
                return this._name;
            };

            Travel.prototype.setName = function(name) {
                this.validateNonEmptyString(name, 'name');
                this._name = name;
            };

            Travel.prototype.getStartDate = function() {
                return this._startDate;
            };

            Travel.prototype.setStartDate = function(startDate) {
                //TODO validation
                this._startDate = new Date(startDate);
                this._startDate = Object.prototype.formatDate(startDate);
            };

            Travel.prototype.getEndtDate = function() {
                return this._endDate;
            };

            Travel.prototype.setEndDate = function(endDate) {
                //TODO validation
                this._endDate =new Date(endDate);
                this._endDate = Object.prototype.formatDate(endDate);
            };

            Travel.prototype.getPrice = function() {
                return this._price;
            };

            Travel.prototype.setPrice = function(price) {
                this.validateIntegerRange(price, 'Price', 0, Number.MAX_VALUE);
                this._price = price;
            };            

            Travel.prototype.toString = function() {
                return " * "+this.constructor.name + ": "+ "name="+this.getName()+",start-date="+this.getStartDate()+",end-date="+this.getEndtDate()+",price="+this.getPrice().toFixed(2);
            };
            
            return Travel;
        
        }());

        


        var Excursion = (function() {          
            function Excursion(name, startDate, endDate, price, transport) {                
                if (!(this instanceof Excursion)) {
                    return new Excursion(args);
                }
                Travel.call(this, name, startDate, endDate, price);
                this.setTransort(transport);
                this._destinations = [];                
                //this.getDestinations();
                
            }
            Excursion.extends(Travel);

            Excursion.prototype.addDestination = function(destination) {
                if(!(destination instanceof Destination)){
                    throw new TypeError("Item should be instance of Recipe");
                };
                this._destinations.push(destination); 
            };

            Excursion.prototype.removeDestination = function(destination) {
                if(!(destination instanceof Destination)){
                    throw new TypeError("Item should be instance of Recipe");
                };
                var index = this._destinations.indexOf(destination);
                this._destinations.splice(index, 1);
            };

            // Excursion.prototype.getDestinations = function() {
            //     return this._destinations = [];
            // };

            Excursion.prototype.getTransport = function() {
                return this._transport;
            };

            Excursion.prototype.setTransort = function(transport) {
               this.validateNonEmptyString(transport, 'Transport');
                this._transport = transport;
            };           
            

            Excursion.prototype.toString = function() {              
                var result = '';
                // if(this._destinations.length){
                //     result += Travel.prototype.toString.call(this)+",transport="+this.getTransport();
                //     this._destinations.forEach(function(_destinations){
                //         result+=this._destinations.toString();
                //     })
                // }else{
                //     result += Travel.prototype.toString.call(this)+",transport="+this.getTransport()+ '\n'+ '** Destinations: -';
                // }
                if(!this._destinations.length){
                    result+= Travel.prototype.toString.call(this)+",transport="+this.getTransport()+ '\n'+ ' ** Destinations: -';
                }else{
                    result+= Travel.prototype.toString.call(this)+",transport="+this.getTransport()+'\n'+ ' ** Destinations: ';
                    for (var i = this._destinations.length - 1; i >= 0; i--) {
                        result+=this._destinations[i].toString();
                    };
                }
                return result;
            };
            
            return Excursion;
        
        }());
        // var dest1 = new Destination("weewe", "weweew2");
        
        

        // var exc = new Excursion("wewew", "23232", "2322", 2323.454, 'BUS');
        // console.log(exc.toString());

        // var testDate = new Date("23-Jan-2014");
        // testDate = Object.prototype.formatDate(testDate);

                

        var Vacation = (function() {
            'use strict';
        
            function Vacation(name, startDate, endDate, price, location, accommodation) {
                // enforces new
                if (!(this instanceof Vacation)) {
                    return new Vacation(locaion, accommodation);
                }
                Travel.call(this, name, startDate, endDate, price);
                this.setLocation(location);
                if(accommodation !== undefined){
                    this.setAccommodation(accommodation);
                }
                
                
            }
            Vacation.extends(Travel);

            Vacation.prototype.getLocation = function() {
                return this._location;
            };

            Vacation.prototype.setLocation = function(location) {
                this.validateNonEmptyString(location, 'Location');
                this._location = location;
            };

            Vacation.prototype.getAccommodation = function( ) {
                return this._accommodation;
            };

            Vacation.prototype.setAccommodation = function(accommodation) {
                if(accommodation === ''){
                    throw new Error('accommodation should be non empty string');
                }
                this._accommodation = accommodation;
            };
        
            Vacation.prototype.toString = function() {
                if(this._accommodation === undefined){
                    return Travel.prototype.toString.call(this)+",location="+this.getLocation();
                }else{
                    return Travel.prototype.toString.call(this)+",location="+this.getLocation()+",accommodation="+this.getAccommodation();
                }                              
                
            };
        
            return Vacation;
        
        }());

            

        var Cruise = (function() {
            'use strict';
        
            function Cruise(name, startDate, endDate, price, startDock) {
                // enforces new
                if (!(this instanceof Cruise)) {
                    return new Cruise(name, startDate, endDate, price, transport, startDock);
                }
                Excursion.call(this, name, startDate, endDate, price, "cruise liner");
                if(startDock !== undefined){
                    this.setStartDock(startDock);
                }             
                
            }
            Cruise.extends(Excursion);

            Cruise.prototype.getStartDock = function() {
                return this._startDock;
            };

            Cruise.prototype.setStartDock = function(startDock) {
                if(this._startDock === ''){
                    throw new Error('Start dock should be non empty string');
                }
                this._startDock = startDock;
            };

            Cruise.prototype.toString = function() {
                if(this._startDock !== undefined){                    
                     return Travel.prototype.toString.call(this)+",transport="+this.getTransport()+",starting dock="+this.getStartDock()+'\n'+'** Destinations: -';
                   }else{
                    return Travel.prototype.toString.call(this)+",transport="+this.getTransport()+'\n'+'** Destinations: -';
                   }              
                
            }
            return Cruise;
        
        }());
            
            // var cruise = new Cruise("name", "startdate", "enddate", 232.45);
            // console.log(cruise.toString());

        return {
            Destination: Destination,
            Travel: Travel,
            Excursion: Excursion,
            Vacation: Vacation,
            Cruise: Cruise
        }
    }());

    var TravellingManager = (function(){
        var _travels;
        var _destinations;

        function init() {
            _travels = [];
            _destinations = [];
        }

        var CommandProcessor = (function() {

            function processInsertCommand(command) {
                var object;

                switch (command["type"]) {
                    case "excursion":
                        object = new Models.Excursion(command["name"], parseDate(command["start-date"]), parseDate(command["end-date"]),
                            parseFloat(command["price"]), command["transport"]);
                        _travels.push(object);
                        break;
                    case "vacation":
                        object = new Models.Vacation(command["name"], parseDate(command["start-date"]), parseDate(command["end-date"]),
                            parseFloat(command["price"]), command["location"], command["accommodation"]);
                        _travels.push(object);
                        break;
                    case "cruise":
                        object = new Models.Cruise(command["name"], parseDate(command["start-date"]), parseDate(command["end-date"]),
                            parseFloat(command["price"]), command["start-dock"]);
                        _travels.push(object);
                        break;
                    case "destination":
                        object = new Models.Destination(command["location"], command["landmark"]);
                        _destinations.push(object);
                        break;
                    default:
                        throw new Error("Invalid type.");
                }

                return object.constructor.name + " created.";
            }

            function processDeleteCommand(command) {
                var object,
                    index,
                    destinations;

                switch (command["type"]) {
                    case "destination":
                        object = getDestinationByLocationAndLandmark(command["location"], command["landmark"]);
                        _travels.forEach(function(t) {
                            if (t instanceof Models.Excursion && t.getDestinations().indexOf(object) !== -1) {
                                t.removeDestination(object);
                            }
                        });
                        index = _destinations.indexOf(object);
                        _destinations.splice(index, 1);
                        break;
                    case "excursion":
                    case "vacation":
                    case "cruise":
                        object = getTravelByName(command["name"]);
                        index = _travels.indexOf(object);
                        _travels.splice(index, 1);
                        break;
                    default:
                        throw new Error("Unknown type.");
                }

                return object.constructor.name + " deleted.";
            }

            function processListCommand(command) {
                return formatTravelsQuery(_travels);
            }

            function processAddDestinationCommand(command) {
                var destination = getDestinationByLocationAndLandmark(command["location"], command["landmark"]),
                    travel = getTravelByName(command["name"]);

                if (!(travel instanceof Models.Excursion)) {
                    throw new Error("Travel does not have destinations.");
                }
                travel.addDestination(destination);

                return "Added destination to " + travel.getName() + ".";
            }

            function processRemoveDestinationCommand(command) {
                var destination = getDestinationByLocationAndLandmark(command["location"], command["landmark"]),
                    travel = getTravelByName(command["name"]);

                if (!(travel instanceof Models.Excursion)) {
                    throw new Error("Travel does not have destinations.");
                }
                travel.removeDestination(destination);

                return "Removed destination from " + travel.getName() + ".";
            }

            function getTravelByName(name) {
                var i;

                for (i = 0; i < _travels.length; i++) {
                    if (_travels[i].getName() === name) {
                        return _travels[i];
                    }
                }
                throw new Error("No travel with such name exists.");
            }

            function getDestinationByLocationAndLandmark(location, landmark) {
                var i;

                for (i = 0; i < _destinations.length; i++) {
                    if (_destinations[i].getLocation() === location
                        && _destinations[i].getLandmark() === landmark) {
                        return _destinations[i];
                    }
                }
                throw new Error("No destination with such location and landmark exists.");
            }

            function formatTravelsQuery(travelsQuery) {
                var queryString = "";

                if (travelsQuery.length > 0) {
                    queryString += travelsQuery.join("\n");
                } else {
                    queryString = "No results.";
                }

                return queryString;
            }

            return {
                processInsertCommand: processInsertCommand,
                processDeleteCommand: processDeleteCommand,
                processListCommand: processListCommand,
                processAddDestinationCommand: processAddDestinationCommand,
                processRemoveDestinationCommand: processRemoveDestinationCommand
            }
        }());

        var Command = (function() {
            function Command(cmdLine) {
                this._cmdArgs = processCommand(cmdLine);
            }

            function processCommand(cmdLine) {
                var parameters = [],
                    matches = [],
                    pattern = /(.+?)=(.+?)[;)]/g,
                    key,
                    value,
                    split;

                split = cmdLine.split("(");
                parameters["command"] = split[0];
                while ((matches = pattern.exec(split[1])) !== null) {
                    key = matches[1];
                    value = matches[2];
                    parameters[key] = value;
                }

                return parameters;
            }

            return Command;
        }());

        function executeCommands(cmds) {
            var commandArgs = new Command(cmds)._cmdArgs,
                action = commandArgs["command"],
                output;

            switch (action) {
                case "insert":
                    output = CommandProcessor.processInsertCommand(commandArgs);
                    break;
                case "delete":
                    output = CommandProcessor.processDeleteCommand(commandArgs);
                    break;
                case "add-destination":
                    output = CommandProcessor.processAddDestinationCommand(commandArgs);
                    break;
                case "remove-destination":
                    output = CommandProcessor.processRemoveDestinationCommand(commandArgs);
                    break;
                case "list":
                    output = CommandProcessor.processListCommand(commandArgs);
                    break;
                case "filter":
                    output = CommandProcessor.processFilterTravelsCommand(commandArgs);
                    break;
                default:
                    throw new Error("Unsupported command.");
            }

            return output;
        }

        return {
            init: init,
            executeCommands: executeCommands
        }
    }());

    var parseDate = function (dateStr) {
        if (!dateStr) {
            return undefined;
        }
        var date = new Date(Date.parse(dateStr.replace(/-/g, ' ')));
        var dateFormatted = formatDate(date);
        if (dateStr != dateFormatted) {
            throw new Error("Invalid date: " + dateStr);
        }
        return date;
    }
    
    var formatDate = function (date) {
        var day = date.getDate();
        var monthName = date.toString().split(' ')[1];
        var year = date.getFullYear();
        return day + '-' + monthName + '-' + year;
    }   

    

    var output = "";
    TravellingManager.init();

    commands.forEach(function(cmd) {
        var result;
        if (cmd != "") {
            try {
                result = TravellingManager.executeCommands(cmd) + "\n";
            } catch (e) {
                // console.log(e.stack);
                result = "Invalid command." + "\n";
            }
            output += result;
        }
    });

    return output;
}

// ------------------------------------------------------------
// Read the input from the console as array and process it
// Remove all below code before submitting to the judge system!
// ------------------------------------------------------------

(function() {
    var arr = [];
    if (typeof (require) == 'function') {
        // We are in node.js --> read the console input and process it
        require('readline').createInterface({
            input: process.stdin,
            output: process.stdout
        }).on('line', function(line) {
            arr.push(line);
        }).on('close', function() {
            console.log(processTravelAgencyCommands(arr));
        });
    }
})();